using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Constants.StockUnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Queries.GetById;

public class GetByIdStockUnsuitReasonQuery : IRequest<GetByIdStockUnsuitReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public StockUnsuitReasonsDetailLevel? DetailLevel { get; set; }


    public class GetByIdStockUnsuitReasonQueryHandler : IRequestHandler<GetByIdStockUnsuitReasonQuery, GetByIdStockUnsuitReasonResponse>
    {
        private readonly IStockUnsuitReasonRepository _stockUnsuitReasonRepository;
        private readonly StockUnsuitReasonBusinessRules _stockUnsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdStockUnsuitReasonQueryHandler(IStockUnsuitReasonRepository stockUnsuitReasonRepository, IMapper mapper, StockUnsuitReasonBusinessRules stockUnsuitReasonBusinessRules)
        {
            _stockUnsuitReasonRepository = stockUnsuitReasonRepository;
            _mapper = mapper;
            _stockUnsuitReasonBusinessRules = stockUnsuitReasonBusinessRules;
        }

        public async Task<GetByIdStockUnsuitReasonResponse> Handle(GetByIdStockUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _stockUnsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdStockUnsuitReasonResponse>(await _stockUnsuitReasonRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<StockUnsuitReason> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeUnsuitReason)
                    {
                        query = query.Include(y => y.UnsuitReason);
                    }

                    var includableQuery = query as IIncludableQueryable<StockUnsuitReason, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdStockUnsuitReasonResponse>(await _stockUnsuitReasonRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
