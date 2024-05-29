using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Constants.AddressOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Delete;

public class DeleteAddressCommand : IRequest<DeletedAddressResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, AddressOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetAddresses";

    public Guid Id { get; set; }


    public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, DeletedAddressResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly AddressBusinessRules _addressBusinessRules;

        public DeleteAddressCommandHandler(IAddressRepository addressRepository, AddressBusinessRules addressBusinessRules)
        {
            _addressRepository = addressRepository;
            _addressBusinessRules = addressBusinessRules;
        }

        public async Task<DeletedAddressResponse> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            _addressBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Address? address = await _addressRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _addressRepository.DeleteAsync(address);

            return new DeletedAddressResponse
            {
                Id = address.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = AddressMessages.RequestExecutedSuccessfully
            };
        }
    }

}

