using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Update;

public class UpdateReturnItemMemoCommand : IRequest<UpdatedReturnItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnItemMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItemMemos";

    public UpdateReturnItemMemoDto ReturnItemMemo { get; set; }


    public class UpdateReturnItemMemoCommandHandler : IRequestHandler<UpdateReturnItemMemoCommand, UpdatedReturnItemMemoResponse>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnItemMemoCommandHandler(IReturnItemMemoRepository returnItemMemoRepository, ReturnItemMemoBusinessRules returnItemMemoBusinessRules, IMapper mapper)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnItemMemoResponse> Handle(UpdateReturnItemMemoCommand request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnItemMemo.Id)
            .CheckReturnItemIdExistence(request.ReturnItemMemo.ReturnItemId);

            ReturnItemMemo? currentReturnItemMemo = await _returnItemMemoRepository.GetAsync(predicate: x => x.Id == request.ReturnItemMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnItemMemo? returnItemMemo = _mapper.Map(request.ReturnItemMemo, currentReturnItemMemo);
            returnItemMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReturnItemMemoResponse>(await _returnItemMemoRepository.UpdateAsync(returnItemMemo));
        }
    }
}

