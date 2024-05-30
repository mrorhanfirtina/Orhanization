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
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants.ReceiptAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Queries.GetById;

public class GetByIdReceiptAttributeValueQuery : IRequest<GetByIdReceiptAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReceiptAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class GetByIdReceiptAttributeValueQueryHandler : IRequestHandler<GetByIdReceiptAttributeValueQuery, GetByIdReceiptAttributeValueResponse>
    {
        private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
        private readonly ReceiptAttributeValueBusinessRules _receiptAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptAttributeValueQueryHandler(IReceiptAttributeValueRepository receiptAttributeValueRepository, IMapper mapper, ReceiptAttributeValueBusinessRules receiptAttributeValueBusinessRules)
        {
            _receiptAttributeValueRepository = receiptAttributeValueRepository;
            _mapper = mapper;
            _receiptAttributeValueBusinessRules = receiptAttributeValueBusinessRules;
        }

        public async Task<GetByIdReceiptAttributeValueResponse> Handle(GetByIdReceiptAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _receiptAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReceiptAttributeValueResponse>(await _receiptAttributeValueRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReceiptAttributeValueResponse>(await _receiptAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
