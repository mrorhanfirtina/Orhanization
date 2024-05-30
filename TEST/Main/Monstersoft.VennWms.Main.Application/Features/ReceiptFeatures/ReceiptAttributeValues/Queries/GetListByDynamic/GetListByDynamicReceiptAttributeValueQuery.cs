using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants.ReceiptAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicReceiptAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ReceiptAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class GetListByDynamicReceiptAttributeValueQueryHandler : IRequestHandler<GetListByDynamicReceiptAttributeValueQuery, GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>
    {
        private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
        private readonly ReceiptAttributeValueBusinessRules _receiptAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiptAttributeValueQueryHandler(IReceiptAttributeValueRepository receiptAttributeValueRepository, IMapper mapper, ReceiptAttributeValueBusinessRules receiptAttributeValueBusinessRules)
        {
            _receiptAttributeValueRepository = receiptAttributeValueRepository;
            _receiptAttributeValueBusinessRules = receiptAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>> Handle(GetListByDynamicReceiptAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _receiptAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ReceiptAttributeValue> receiptAttributeValueList = await _receiptAttributeValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ReceiptAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipt);
                    }

                    if (detailLevel.IncludeReceiptAttribute)
                    {
                        query = query.Include(y => y.ReceiptAttribute);

                        if (detailLevel.ReceiptAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ReceiptAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptAttributeValue, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>(receiptAttributeValueList);
            }
            else
            {
                Paginate<ReceiptAttributeValue> receiptAttributeValueList = await _receiptAttributeValueRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicReceiptAttributeValueListItemDto>>(receiptAttributeValueList);
            }
        }
    }

}
