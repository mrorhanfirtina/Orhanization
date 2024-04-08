using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetListByDynamic;

public class GetListByDynamicReceiverQuery : IRequest<GetListResponse<GetListByDynamicReceiverListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }



    public class GetListByDynamicReceiverQueryHandler : IRequestHandler<GetListByDynamicReceiverQuery, GetListResponse<GetListByDynamicReceiverListItemDto>>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReceiverQueryHandler(IReceiverRepository receiverRepository, IMapper mapper, ReceiverBusinessRules receiverBusinessRules)
        {
            _receiverRepository = receiverRepository;
            _receiverBusinessRules = receiverBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReceiverListItemDto>> Handle(GetListByDynamicReceiverQuery request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Receiver> receiverList = await _receiverRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReceiverListItemDto>>(receiverList);
        }
    }

}
