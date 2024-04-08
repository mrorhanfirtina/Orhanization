using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Create;

public class CreatePoAttributeValueCommand : IRequest<CreatedPoAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributeValues";

    public CreatePoAttributeValueDto PoAttributeValue { get; set; }


    public class CreatePoAttributeValueCommandHandler : IRequestHandler<CreatePoAttributeValueCommand, CreatedPoAttributeValueResponse>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreatePoAttributeValueCommandHandler(IPoAttributeValueRepository poAttributeValueRepository, IMapper mapper, PoAttributeValueBusinessRules poAttributeValueBusinessRules)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _mapper = mapper;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
        }

        public async Task<CreatedPoAttributeValueResponse> Handle(CreatePoAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckPurchaseOrderIdExistence(request.PoAttributeValue.PurchaseOrderId)
                .CheckPoAttributeIdExistence(request.PoAttributeValue.PoAttributeId);

            PoAttributeValue poAttributeValue = _mapper.Map<PoAttributeValue>(request.PoAttributeValue);
            poAttributeValue.Id = Guid.NewGuid();
            poAttributeValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedPoAttributeValueResponse>(await _poAttributeValueRepository.AddAsync(poAttributeValue));
        }
    }

}

