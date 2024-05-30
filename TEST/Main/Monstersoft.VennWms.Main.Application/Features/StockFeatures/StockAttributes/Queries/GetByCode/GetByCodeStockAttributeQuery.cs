using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Queries.GetByCode;

public class GetByCodeStockAttributeQuery : IRequest<GetByCodeStockAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public StockAttributesDetailLevel? DetailLevel { get; set; }



    public class GetByCodeStockAttributeQueryHandler : IRequestHandler<GetByCodeStockAttributeQuery, GetByCodeStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeStockAttributeQueryHandler(IStockAttributeRepository stockAttributeRepository, IMapper mapper, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _mapper = mapper;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
        }

        public async Task<GetByCodeStockAttributeResponse> Handle(GetByCodeStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeStockAttributeResponse>(await _stockAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<StockAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    var includableQuery = query as IIncludableQueryable<StockAttribute, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeStockAttributeResponse>(await _stockAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
