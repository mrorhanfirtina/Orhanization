using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants.ReturnItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;

public class CreateReturnItemMemoCommand : IRequest<CreatedReturnItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItemMemos";

    public CreateReturnItemMemoDto ReturnItemMemo { get; set; }


    public class CreateReturnItemMemoCommandHandler : IRequestHandler<CreateReturnItemMemoCommand, CreatedReturnItemMemoResponse>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnItemMemoCommandHandler(IReturnItemMemoRepository returnItemMemoRepository, IMapper mapper, ReturnItemMemoBusinessRules returnItemMemoBusinessRules)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _mapper = mapper;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
        }

        public async Task<CreatedReturnItemMemoResponse> Handle(CreateReturnItemMemoCommand request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnItemIdExistence(request.ReturnItemMemo.ReturnItemId);

            ReturnItemMemo returnItemMemo = _mapper.Map<ReturnItemMemo>(request.ReturnItemMemo);
            returnItemMemo.Id = Guid.NewGuid();
            returnItemMemo.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReturnItemMemoResponse>(await _returnItemMemoRepository.AddAsync(returnItemMemo));
        }
    }
}

