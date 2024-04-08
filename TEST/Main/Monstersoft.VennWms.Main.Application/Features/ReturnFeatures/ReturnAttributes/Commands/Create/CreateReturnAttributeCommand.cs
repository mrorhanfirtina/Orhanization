using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants.ReturnAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Create;

public class CreateReturnAttributeCommand : IRequest<CreatedReturnAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributes";

    public CreateReturnAttributeDto ReturnAttribute { get; set; }


    public class CreateReturnAttributeCommandHandler : IRequestHandler<CreateReturnAttributeCommand, CreatedReturnAttributeResponse>
    {
        private readonly IReturnAttributeRepository _returnAttributeRepository;
        private readonly ReturnAttributeBusinessRules _returnAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnAttributeCommandHandler(IReturnAttributeRepository returnAttributeRepository, IMapper mapper, ReturnAttributeBusinessRules returnAttributeBusinessRules)
        {
            _returnAttributeRepository = returnAttributeRepository;
            _mapper = mapper;
            _returnAttributeBusinessRules = returnAttributeBusinessRules;
        }

        public async Task<CreatedReturnAttributeResponse> Handle(CreateReturnAttributeCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckAttributeInputTypeIdExistence(request.ReturnAttribute.AttributeInputTypeId)
                .CheckCodeExistenceWhenCreate(request.ReturnAttribute.Code);

            ReturnAttribute returnAttribute = _mapper.Map<ReturnAttribute>(request.ReturnAttribute);
            returnAttribute.Id = Guid.NewGuid();
            returnAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            returnAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReturnAttributeResponse>(await _returnAttributeRepository.AddAsync(returnAttribute));
        }
    }
}
