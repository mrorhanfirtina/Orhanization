using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Update;

public class UpdateTransactionTypeCommand : IRequest<UpdatedTransactionTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, TaskCodeFormatOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionTypes";

    public UpdateTransactionTypeDto TransactionType { get; set; }


    public class UpdateTransactionTypeCommandHandler : IRequestHandler<UpdateTransactionTypeCommand, UpdatedTransactionTypeResponse>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateTransactionTypeCommandHandler(ITransactionTypeRepository transactionTypeRepository, TransactionTypeBusinessRules transactionTypeBusinessRules, IMapper mapper)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedTransactionTypeResponse> Handle(UpdateTransactionTypeCommand request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.TransactionType.Id)
            .CheckCodeExistenceWhenUpdate(request.TransactionType.Code, request.TransactionType.Id);

            TransactionType? currentTransactionType = await _transactionTypeRepository.GetAsync(predicate: x => x.Id == request.TransactionType.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            TransactionType? transactionType = _mapper.Map(request.TransactionType, currentTransactionType);
            transactionType.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedTransactionTypeResponse>(await _transactionTypeRepository.UpdateAsync(transactionType));
        }
    }
}

