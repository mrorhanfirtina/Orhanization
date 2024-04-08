using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetList;

public class GetListReceiverQuery : IRequest<GetListResponse<GetListReceiverListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListReceiverQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetReceivers";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListReceiverQueryHandler : IRequestHandler<GetListReceiverQuery, GetListResponse<GetListReceiverListItemDto>>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public GetListReceiverQueryHandler(IReceiverRepository receiverRepository, IMapper mapper, ReceiverBusinessRules receiverBusinessRules)
        {
            _receiverRepository = receiverRepository;
            _mapper = mapper;
            _receiverBusinessRules = receiverBusinessRules;
        }

        public async Task<GetListResponse<GetListReceiverListItemDto>> Handle(GetListReceiverQuery request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Receiver> receiverList = await _receiverRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListReceiverListItemDto>>(receiverList);
        }
    }

}
