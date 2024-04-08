using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;

public class UpdatePoAttributeValueCommand : IRequest<UpdatedPoAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributeValues";

    public UpdatePoAttributeValueDto PoAttributeValue { get; set; }


    public class UpdatePoAttributeValueCommandHandler : IRequestHandler<UpdatePoAttributeValueCommand, UpdatedPoAttributeValueResponse>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePoAttributeValueCommandHandler(IPoAttributeValueRepository poAttributeValueRepository, PoAttributeValueBusinessRules poAttributeValueBusinessRules, IMapper mapper)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPoAttributeValueResponse> Handle(UpdatePoAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.PoAttributeValue.Id)
            .CheckPurchaseOrderIdExistence(request.PoAttributeValue.PurchaseOrderId)
            .CheckPoAttributeIdExistence(request.PoAttributeValue.PoAttributeId);

            PoAttributeValue? currentPoAttributeValue = await _poAttributeValueRepository.GetAsync(predicate: x => x.Id == request.PoAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            PoAttributeValue? poAttributeValue = _mapper.Map(request.PoAttributeValue, currentPoAttributeValue);
            poAttributeValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedPoAttributeValueResponse>(await _poAttributeValueRepository.UpdateAsync(poAttributeValue));
        }
    }
}

