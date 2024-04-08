using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Constants.OrderAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Queries.GetByCode;

public class GetByCodeOrderAttributeQuery : IRequest<GetByCodeOrderAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeOrderAttributeQueryHandler : IRequestHandler<GetByCodeOrderAttributeQuery, GetByCodeOrderAttributeResponse>
    {
        private readonly IOrderAttributeRepository _orderAttributeRepository;
        private readonly OrderAttributeBusinessRules _orderAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeOrderAttributeQueryHandler(IOrderAttributeRepository orderAttributeRepository, IMapper mapper, OrderAttributeBusinessRules orderAttributeBusinessRules)
        {
            _orderAttributeRepository = orderAttributeRepository;
            _mapper = mapper;
            _orderAttributeBusinessRules = orderAttributeBusinessRules;
        }

        public async Task<GetByCodeOrderAttributeResponse> Handle(GetByCodeOrderAttributeQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeOrderAttributeResponse>(await _orderAttributeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

