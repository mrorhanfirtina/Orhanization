using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
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
    public string? CacheGroupKey => "GetReceiptAttributeValues";

    public CreateReceiptAttributeValueDto ReceiptAttributeValue { get; set; }


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

            return _mapper.Map<CreatedReceiptAttributeValueResponse>(await _receiptAttributeValueRepository.AddAsync(receiptAttributeValue));
        }
    }

}
