using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants.ReceiptAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetByCode;

public class GetByCodeReceiptAttributeQuery : IRequest<GetByCodeReceiptAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public ReceiptAttributesDetailLevel? DetailLevel { get; set; }


    public class GetByCodeReceiptAttributeQueryHandler : IRequestHandler<GetByCodeReceiptAttributeQuery, GetByCodeReceiptAttributeResponse>
    {
        private readonly IReceiptAttributeRepository _receiptAttributeRepository;
        private readonly ReceiptAttributeBusinessRules _receiptAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReceiptAttributeQueryHandler(IReceiptAttributeRepository receiptAttributeRepository, IMapper mapper, ReceiptAttributeBusinessRules receiptAttributeBusinessRules)
        {
            _receiptAttributeRepository = receiptAttributeRepository;
            _mapper = mapper;
            _receiptAttributeBusinessRules = receiptAttributeBusinessRules;
        }

        public async Task<GetByCodeReceiptAttributeResponse> Handle(GetByCodeReceiptAttributeQuery request, CancellationToken cancellationToken)
        {
            _receiptAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeReceiptAttributeResponse>(await _receiptAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<ReceiptAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }


                    var includableQuery = query as IIncludableQueryable<ReceiptAttribute, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeReceiptAttributeResponse>(await _receiptAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

