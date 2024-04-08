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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetById;

public class GetByIdReceiverQuery : IRequest<GetByIdReceiverResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReceiverQueryHandler : IRequestHandler<GetByIdReceiverQuery, GetByIdReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiverQueryHandler(IReceiverRepository receiverRepository, IMapper mapper, ReceiverBusinessRules receiverBusinessRules)
        {
            _receiverRepository = receiverRepository;
            _mapper = mapper;
            _receiverBusinessRules = receiverBusinessRules;
        }

        public async Task<GetByIdReceiverResponse> Handle(GetByIdReceiverQuery request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReceiverResponse>(await _receiverRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(m => m.Address),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
