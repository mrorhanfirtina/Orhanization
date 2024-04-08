using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants.OrderTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetByCode;

public class GetByCodeOrderTypeQuery : IRequest<GetByCodeOrderTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeOrderTypeQueryHandler : IRequestHandler<GetByCodeOrderTypeQuery, GetByCodeOrderTypeResponse>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeOrderTypeQueryHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _mapper = mapper;
            _orderTypeBusinessRules = orderTypeBusinessRules;
        }

        public async Task<GetByCodeOrderTypeResponse> Handle(GetByCodeOrderTypeQuery request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeOrderTypeResponse>(await _orderTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Orders),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
