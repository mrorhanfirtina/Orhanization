using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;

public class UpdateReceiverCommand : IRequest<UpdatedReceiverResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiverOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceivers"];

    public UpdateReceiverDto Receiver { get; set; }
    public ReceiversDetailLevel DetailLevel { get; set; }


    public class UpdateReceiverCommandHandler : IRequestHandler<UpdateReceiverCommand, UpdatedReceiverResponse>
    {
        private readonly IReceiverRepository _receiverRepository;
        private readonly ReceiverBusinessRules _receiverBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiverCommandHandler(IReceiverRepository receiverRepository, ReceiverBusinessRules receiverBusinessRules, IMapper mapper)
        {
            _receiverRepository = receiverRepository;
            _receiverBusinessRules = receiverBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedReceiverResponse> Handle(UpdateReceiverCommand request, CancellationToken cancellationToken)
        {
            _receiverBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckIdExistence(request.Receiver.Id)
                .CheckCodeExistenceWhenUpdate(request.Receiver.Code, request.Receiver.Id)
                .CheckCustomerIdExistence(request.Receiver.CustomerId);

            Receiver currentReceiver = await _receiverRepository.GetAsync(predicate: x => x.Id == request.Receiver.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Receiver? receiver = _mapper.Map(request.Receiver, currentReceiver);
            receiver.UpdatedDate = DateTime.Now;
            receiver.Address.UpdatedDate = DateTime.Now;

            await _receiverRepository.UpdateAsync(receiver);

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

                return _mapper.Map<UpdatedReceiverResponse>(response);
            }
            else
            {
                var response = await _receiverRepository.GetAsync(predicate: x => x.Id == receiver.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiverResponse>(response);
            }
        }
    }
}
