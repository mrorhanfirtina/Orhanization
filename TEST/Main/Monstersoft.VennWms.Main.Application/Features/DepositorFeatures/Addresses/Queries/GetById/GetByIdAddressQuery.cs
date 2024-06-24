using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Constants.AddressOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Queries.GetById;

public class GetByIdAddressQuery : IRequest<GetByIdAddressResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQuery, GetByIdAddressResponse>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly AddressBusinessRules _addressBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdAddressQueryHandler(IAddressRepository addressRepository, IMapper mapper, AddressBusinessRules addressBusinessRules)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
            _addressBusinessRules = addressBusinessRules;
        }

        public async Task<GetByIdAddressResponse> Handle(GetByIdAddressQuery request, CancellationToken cancellationToken)
        {
            _addressBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdAddressResponse>(await _addressRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

