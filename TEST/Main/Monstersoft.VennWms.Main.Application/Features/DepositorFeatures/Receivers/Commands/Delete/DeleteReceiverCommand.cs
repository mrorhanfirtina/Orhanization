using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Delete;

public class DeleteReceiverCommand : IRequest<DeletedReceiverResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ReceiverOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceivers";

    public Guid Id { get; set; }


    public class DeleteReceiverCommandHandler : IRequestHandler<DeleteReceiverCommand, DeletedReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IAddressRepository _addressRepository;

        public DeleteReceiverCommandHandler(IReceiverRepository receiverRepository, ReceiverBusinessRules receiverBusinessRules, IAddressRepository addressRepository)
        {
            _receiverRepository = receiverRepository;
            _receiverBusinessRules = receiverBusinessRules;
            _addressRepository = addressRepository;
        }

        public async Task<DeletedReceiverResponse> Handle(DeleteReceiverCommand request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Receiver receiver = await _receiverRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _receiverRepository.DeleteAsync(receiver);
            await _addressRepository.DeleteAsync(receiver.Address);

            return new DeletedReceiverResponse
            {
                Id = receiver.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = ReceiverMessages.RequestExecutedSuccessfully
            };
        }
    }

}
