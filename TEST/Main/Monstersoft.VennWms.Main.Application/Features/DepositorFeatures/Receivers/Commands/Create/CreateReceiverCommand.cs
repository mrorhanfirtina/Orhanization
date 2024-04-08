using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;

public class CreateReceiverCommand : IRequest<CreatedReceiverResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceivers";

    public CreateReceiverDto Receiver { get; set; }


    public class CreateReceiverCommandHandler : IRequestHandler<CreateReceiverCommand, CreatedReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiverCommandHandler(IReceiverRepository receiverRepository, ReceiverBusinessRules receiverBusinessRules, IMapper mapper)
        {
            _receiverRepository = receiverRepository;
            _receiverBusinessRules = receiverBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedReceiverResponse> Handle(CreateReceiverCommand request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.CreateRequest()
            .CheckCodeExistenceWhenCreate(request.Receiver.Code)
            .CheckCustomerIdExistence(request.Receiver.CustomerId);

            Receiver receiver = _mapper.Map<Receiver>(request.Receiver);
            receiver.Id = Guid.NewGuid();
            receiver.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            receiver.CreatedDate = DateTime.Now;
            receiver.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedReceiverResponse>(await _receiverRepository.AddAsync(receiver));
        }
    }
}
