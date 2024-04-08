using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants.ReceiptAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;

public class CreateReceiptAttributeCommand : IRequest<CreatedReceiptAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptAttributes";

    public CreateReceiptAttributeDto ReceiptAttribute { get; set; }


    public class CreateReceiptAttributeCommandHandler : IRequestHandler<CreateReceiptAttributeCommand, CreatedReceiptAttributeResponse>
    {
        private readonly IReceiptAttributeRepository _receiptAttributeRepository;
        private readonly ReceiptAttributeBusinessRules _receiptAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptAttributeCommandHandler(IReceiptAttributeRepository receiptAttributeRepository, IMapper mapper, ReceiptAttributeBusinessRules receiptAttributeBusinessRules)
        {
            _receiptAttributeRepository = receiptAttributeRepository;
            _mapper = mapper;
            _receiptAttributeBusinessRules = receiptAttributeBusinessRules;
        }

        public async Task<CreatedReceiptAttributeResponse> Handle(CreateReceiptAttributeCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckAttributeInputTypeIdExistence(request.ReceiptAttribute.AttributeInputTypeId)
                .CheckCodeExistenceWhenCreate(request.ReceiptAttribute.Code);

            ReceiptAttribute receiptAttribute = _mapper.Map<ReceiptAttribute>(request.ReceiptAttribute);
            receiptAttribute.Id = Guid.NewGuid();
            receiptAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            receiptAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReceiptAttributeResponse>(await _receiptAttributeRepository.AddAsync(receiptAttribute));
        }
    }

}

