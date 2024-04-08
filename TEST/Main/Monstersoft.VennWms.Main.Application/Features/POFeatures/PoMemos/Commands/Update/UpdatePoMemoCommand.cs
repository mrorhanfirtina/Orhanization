using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants.PoMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Update;

public class UpdatePoMemoCommand : IRequest<UpdatedPoMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoMemos";

    public UpdatePoMemoDto PoMemo { get; set; }


    public class UpdatePoMemoCommandHandler : IRequestHandler<UpdatePoMemoCommand, UpdatedPoMemoResponse>
    {
        private readonly IPoMemoRepository _poMemoRepository;
        private readonly PoMemoBusinessRules _poMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePoMemoCommandHandler(IPoMemoRepository poMemoRepository, PoMemoBusinessRules poMemoBusinessRules, IMapper mapper)
        {
            _poMemoRepository = poMemoRepository;
            _poMemoBusinessRules = poMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPoMemoResponse> Handle(UpdatePoMemoCommand request, CancellationToken cancellationToken)
        {
            _poMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.PoMemo.Id)
            .CheckPurchaseOrderIdExistence(request.PoMemo.PurchaseOrderId);

            PoMemo? currentPoMemo = await _poMemoRepository.GetAsync(predicate: x => x.Id == request.PoMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            PoMemo? poMemo = _mapper.Map(request.PoMemo, currentPoMemo);
            poMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedPoMemoResponse>(await _poMemoRepository.UpdateAsync(poMemo));
        }
    }
}
