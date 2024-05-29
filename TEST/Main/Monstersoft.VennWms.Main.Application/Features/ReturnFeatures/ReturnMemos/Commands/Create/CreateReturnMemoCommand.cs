using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants.ReturnMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;

public class CreateReturnMemoCommand : IRequest<CreatedReturnMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnMemos";

    public CreateReturnMemoDto ReturnMemo { get; set; }


    public class CreateReturnMemoCommandHandler : IRequestHandler<CreateReturnMemoCommand, CreatedReturnMemoResponse>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnMemoCommandHandler(IReturnMemoRepository returnMemoRepository, IMapper mapper, ReturnMemoBusinessRules returnMemoBusinessRules)
        {
            _returnMemoRepository = returnMemoRepository;
            _mapper = mapper;
            _returnMemoBusinessRules = returnMemoBusinessRules;
        }

        public async Task<CreatedReturnMemoResponse> Handle(CreateReturnMemoCommand request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnIdExistence(request.ReturnMemo.ReturnId);

            ReturnMemo returnMemo = _mapper.Map<ReturnMemo>(request.ReturnMemo);
            returnMemo.Id = Guid.NewGuid();
            returnMemo.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReturnMemoResponse>(await _returnMemoRepository.AddAsync(returnMemo));
        }
    }
}
