using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;

public class CreatePoAttributeCommand : IRequest<CreatedPoAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributes";

    public CreatePoAttributeDto PoAttribute { get; set; }


    public class CreatePoAttributeCommandHandler : IRequestHandler<CreatePoAttributeCommand, CreatedPoAttributeResponse>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreatePoAttributeCommandHandler(IPoAttributeRepository poAttributeRepository, IMapper mapper, PoAttributeBusinessRules poAttributeBusinessRules)
        {
            _poAttributeRepository = poAttributeRepository;
            _mapper = mapper;
            _poAttributeBusinessRules = poAttributeBusinessRules;
        }

        public async Task<CreatedPoAttributeResponse> Handle(CreatePoAttributeCommand request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.PoAttribute.Code)
                .CheckAttributeInputTypeIdExistence(request.PoAttribute.AttributeInputTypeId);

            PoAttribute poAttribute = _mapper.Map<PoAttribute>(request.PoAttribute);
            poAttribute.Id = Guid.NewGuid();
            poAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            poAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedPoAttributeResponse>(await _poAttributeRepository.AddAsync(poAttribute));
        }
    }
}

