using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Update;

public class UpdateReturnMemoCommand : IRequest<UpdatedReturnMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnMemos";

    public UpdateReturnMemoDto ReturnMemo { get; set; }


    public class UpdateReturnMemoCommandHandler : IRequestHandler<UpdateReturnMemoCommand, UpdatedReturnMemoResponse>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnMemoCommandHandler(IReturnMemoRepository returnMemoRepository, ReturnMemoBusinessRules returnMemoBusinessRules, IMapper mapper)
        {
            _returnMemoRepository = returnMemoRepository;
            _returnMemoBusinessRules = returnMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnMemoResponse> Handle(UpdateReturnMemoCommand request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnMemo.Id)
            .CheckReturnIdExistence(request.ReturnMemo.ReturnId);

            ReturnMemo? currentReturnMemo = await _returnMemoRepository.GetAsync(predicate: x => x.Id == request.ReturnMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnMemo? returnMemo = _mapper.Map(request.ReturnMemo, currentReturnMemo);
            returnMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReturnMemoResponse>(await _returnMemoRepository.UpdateAsync(returnMemo));
        }
    }
}
