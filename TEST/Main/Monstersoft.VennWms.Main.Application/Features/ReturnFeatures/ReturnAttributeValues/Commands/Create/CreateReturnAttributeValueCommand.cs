using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;

public class CreateReturnAttributeValueCommand : IRequest<CreatedReturnAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributeValues";

    public CreateReturnAttributeValueDto ReturnAttributeValue { get; set; }


    public class CreateReturnAttributeValueCommandHandler : IRequestHandler<CreateReturnAttributeValueCommand, CreatedReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnAttributeValueCommandHandler(IReturnAttributeValueRepository returnAttributeValueRepository, IMapper mapper, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _mapper = mapper;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
        }

        public async Task<CreatedReturnAttributeValueResponse> Handle(CreateReturnAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnAttributeIdExistence(request.ReturnAttributeValue.ReturnAttributeId)
                .CheckReturnIdExistence(request.ReturnAttributeValue.ReturnId);

            ReturnAttributeValue returnAttributeValue = _mapper.Map<ReturnAttributeValue>(request.ReturnAttributeValue);
            returnAttributeValue.Id = Guid.NewGuid();
            returnAttributeValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReturnAttributeValueResponse>(await _returnAttributeValueRepository.AddAsync(returnAttributeValue));
        }
    }

}

