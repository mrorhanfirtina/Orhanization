using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetByCode;

public class GetByCodeReceiverQuery : IRequest<GetByCodeReceiverResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeReceiverQueryHandler : IRequestHandler<GetByCodeReceiverQuery, GetByCodeReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReceiverQueryHandler(IReceiverRepository receiverRepository, IMapper mapper, ReceiverBusinessRules receiverBusinessRules)
        {
            _receiverRepository = receiverRepository;
            _mapper = mapper;
            _receiverBusinessRules = receiverBusinessRules;
        }

        public async Task<GetByCodeReceiverResponse> Handle(GetByCodeReceiverQuery request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReceiverResponse>(await _receiverRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
