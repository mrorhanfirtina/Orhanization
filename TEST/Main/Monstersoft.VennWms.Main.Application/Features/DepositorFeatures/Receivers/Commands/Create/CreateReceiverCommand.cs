using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;

public class CreateReceiverCommand : IRequest<CreatedReceiverResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceivers"];

    public CreateReceiverDto Receiver { get; set; }
    public ReceiversDetailLevel DetailLevel { get; set; }


    public class CreateReceiverCommandHandler : IRequestHandler<CreateReceiverCommand, CreatedReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiverCommandHandler(IReceiverRepository receiverRepository, ReceiverBusinessRules receiverBusinessRules, IMapper mapper)
        {
            _receiverRepository = receiverRepository;
            _receiverBusinessRules = receiverBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedReceiverResponse> Handle(CreateReceiverCommand request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.Receiver.Code)
            .CheckCustomerIdExistence(request.Receiver.CustomerId);

            Receiver receiver = _mapper.Map<Receiver>(request.Receiver);
            receiver.Id = Guid.NewGuid();
            receiver.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            receiver.CreatedDate = DateTime.Now;

            await _receiverRepository.AddAsync(receiver);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiverRepository.GetAsync(predicate: x => x.Id == receiver.Id,
                include: x =>
                {
                    IQueryable<Receiver> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeCustomer)
                    {
                        query = query.Include(y => y.Customer);

                        if (detailLevel.CustomerDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Customer).ThenInclude(m => m.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Receiver, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiverResponse>(response);
            }
            else
            {
                var response = await _receiverRepository.GetAsync(predicate: x => x.Id == receiver.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiverResponse>(response);
            }
        }
    }
}
