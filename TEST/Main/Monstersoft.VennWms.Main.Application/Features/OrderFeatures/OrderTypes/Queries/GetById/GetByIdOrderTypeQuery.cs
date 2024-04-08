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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;

public class GetByIdOrderTypeQuery : IRequest<GetByIdOrderTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdOrderTypeQueryHandler : IRequestHandler<GetByIdOrderTypeQuery, GetByIdOrderTypeResponse>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderTypeQueryHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _mapper = mapper;
            _orderTypeBusinessRules = orderTypeBusinessRules;
        }

        public async Task<GetByIdOrderTypeResponse> Handle(GetByIdOrderTypeQuery request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdOrderTypeResponse>(await _orderTypeRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.Orders),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
