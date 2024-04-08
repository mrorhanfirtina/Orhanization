using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants.OrderAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;

public class GetByIdOrderAttributeValueQuery : IRequest<GetByIdOrderAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderAttributeValueQueryHandler : IRequestHandler<GetByIdOrderAttributeValueQuery, GetByIdOrderAttributeValueResponse>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderAttributeValueQueryHandler(IOrderAttributeValueRepository orderAttributeValueRepository, IMapper mapper, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _mapper = mapper;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
        }

        public async Task<GetByIdOrderAttributeValueResponse> Handle(GetByIdOrderAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderAttributeValueResponse>(await _orderAttributeValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
