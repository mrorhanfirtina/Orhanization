using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.WorkTaskDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Create;

public class CreateTransactionTypeCommand : IRequest<CreatedTransactionTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetTransactionTypes";

    public CreateTransactionTypeDto TransactionType { get; set; }


    public class CreateTransactionTypeCommandHandler : IRequestHandler<CreateTransactionTypeCommand, CreatedTransactionTypeResponse>
    {
        private readonly ITransactionTypeRepository _transactionTypeRepository;
        private readonly TransactionTypeBusinessRules _transactionTypeBusinessRules;
        private readonly IMapper _mapper;

        public CreateTransactionTypeCommandHandler(ITransactionTypeRepository transactionTypeRepository, IMapper mapper, TransactionTypeBusinessRules transactionTypeBusinessRules)
        {
            _transactionTypeRepository = transactionTypeRepository;
            _mapper = mapper;
            _transactionTypeBusinessRules = transactionTypeBusinessRules;
        }

        public async Task<CreatedTransactionTypeResponse> Handle(CreateTransactionTypeCommand request, CancellationToken cancellationToken)
        {
            _transactionTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.TransactionType.Code);

            TransactionType transactionType = _mapper.Map<TransactionType>(request.TransactionType);
            transactionType.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            transactionType.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedTransactionTypeResponse>(await _transactionTypeRepository.AddAsync(transactionType));
        }
    }
}

