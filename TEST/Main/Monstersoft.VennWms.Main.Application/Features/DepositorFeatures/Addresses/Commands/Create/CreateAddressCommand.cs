using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Create;

public class CreateAddressCommand : IRequest<CreatedAddressResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetAddresses";

    public CreateAddressDto Address { get; set; }


    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, CreatedAddressResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly AddressBusinessRules _addressBusinessRules;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper, AddressBusinessRules addressBusinessRules)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _addressBusinessRules = addressBusinessRules;
        }

        public async Task<CreatedAddressResponse> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            _addressBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Address address = _mapper.Map<Address>(request.Address);
            address.Id = Guid.NewGuid();
            address.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedAddressResponse>(await _addressRepository.AddAsync(address));
        }
    }

}

