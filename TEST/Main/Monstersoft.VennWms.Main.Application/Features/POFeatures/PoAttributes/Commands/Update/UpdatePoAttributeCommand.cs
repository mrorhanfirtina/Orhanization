using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants.PoAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Update;

public class UpdatePoAttributeCommand : IRequest<UpdatedPoAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributes";

    public UpdatePoAttributeDto PoAttribute { get; set; }


    public class UpdatePoAttributeCommandHandler : IRequestHandler<UpdatePoAttributeCommand, UpdatedPoAttributeResponse>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePoAttributeCommandHandler(IPoAttributeRepository poAttributeRepository, PoAttributeBusinessRules poAttributeBusinessRules, IMapper mapper)
        {
            _poAttributeRepository = poAttributeRepository;
            _poAttributeBusinessRules = poAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPoAttributeResponse> Handle(UpdatePoAttributeCommand request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.PoAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.PoAttribute.AttributeInputTypeId)
            .CheckCodeExistenceWhenUpdate(request.PoAttribute.Code, request.PoAttribute.Id);

            PoAttribute? currentPoAttribute = await _poAttributeRepository.GetAsync(predicate: x => x.Id == request.PoAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            PoAttribute? poAttribute = _mapper.Map(request.PoAttribute, currentPoAttribute);
            poAttribute.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedPoAttributeResponse>(await _poAttributeRepository.UpdateAsync(poAttribute));
        }
    }
}

