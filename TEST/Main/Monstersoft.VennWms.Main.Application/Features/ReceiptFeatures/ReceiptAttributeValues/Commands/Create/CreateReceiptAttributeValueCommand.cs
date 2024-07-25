using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants.ReceiptAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Create;

public class CreateReceiptAttributeValueCommand : IRequest<CreatedReceiptAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptAttributeValues"];

    public CreateReceiptAttributeValueDto ReceiptAttributeValue { get; set; }
    public ReceiptAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class CreateReceiptAttributeValueCommandHandler : IRequestHandler<CreateReceiptAttributeValueCommand, CreatedReceiptAttributeValueResponse>
    {
        private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
        private readonly ReceiptAttributeValueBusinessRules _receiptAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptAttributeValueCommandHandler(IReceiptAttributeValueRepository receiptAttributeValueRepository, IMapper mapper, ReceiptAttributeValueBusinessRules receiptAttributeValueBusinessRules)
        {
            _receiptAttributeValueRepository = receiptAttributeValueRepository;
            _mapper = mapper;
            _receiptAttributeValueBusinessRules = receiptAttributeValueBusinessRules;
        }

        public async Task<CreatedReceiptAttributeValueResponse> Handle(CreateReceiptAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReceiptAttributeIdExistence(request.ReceiptAttributeValue.ReceiptAttributeId)
                .CheckReceiptIdExistence(request.ReceiptAttributeValue.ReceiptId);

            ReceiptAttributeValue receiptAttributeValue = _mapper.Map<ReceiptAttributeValue>(request.ReceiptAttributeValue);
            receiptAttributeValue.Id = Guid.NewGuid();
            receiptAttributeValue.CreatedDate = DateTime.Now;

            await _receiptAttributeValueRepository.AddAsync(receiptAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptAttributeValueRepository.GetAsync(predicate: x => x.Id == receiptAttributeValue.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptAttributeValueResponse>(response);
            }
            else
            {
                var response = await _receiptAttributeValueRepository.GetAsync(predicate: x => x.Id == receiptAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptAttributeValueResponse>(response);
            }
        }
    }

}
