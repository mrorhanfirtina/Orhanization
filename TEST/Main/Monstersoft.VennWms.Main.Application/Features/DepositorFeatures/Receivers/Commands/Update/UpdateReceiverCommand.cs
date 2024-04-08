using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants.ReceiverOperationClaims;
using Microsoft.EntityFrameworkCore;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;

public class UpdateReceiverCommand : IRequest<UpdatedReceiverResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiverOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceivers";

    public UpdateReceiverDto Receiver { get; set; }


    public class UpdateReceiverCommandHandler : IRequestHandler<UpdateReceiverCommand, UpdatedReceiverResponse>
    {
        private readonly IReceiverRepository _companyRepository;
        private readonly ReceiverBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiverCommandHandler(IReceiverRepository companyRepository, ReceiverBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedReceiverResponse> Handle(UpdateReceiverCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.UpdateRequest()
                .CheckIdExistence(request.Receiver.Id)
                .CheckAddressIdExistence(request.Receiver.AddressId)
                .CheckCodeExistenceWhenUpdate(request.Receiver.Code, request.Receiver.Id)
                .CheckCustomerIdExistence(request.Receiver.CustomerId);

            Receiver currentReceiver = await _companyRepository.GetAsync(predicate: x => x.Id == request.Receiver.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Receiver? receiver = _mapper.Map(request.Receiver, currentReceiver);
            receiver.UpdatedDate = DateTime.Now;
            receiver.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedReceiverResponse>(await _companyRepository.UpdateAsync(receiver));
        }
    }
}
