using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Commands.Update;

public class UpdateReturnAttributeCommand : IRequest<UpdatedReturnAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributes";

    public UpdateReturnAttributeDto ReturnAttribute { get; set; }


    public class UpdateReturnAttributeCommandHandler : IRequestHandler<UpdateReturnAttributeCommand, UpdatedReturnAttributeResponse>
    {
        private readonly IReturnAttributeRepository _returnAttributeRepository;
        private readonly ReturnAttributeBusinessRules _returnAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnAttributeCommandHandler(IReturnAttributeRepository returnAttributeRepository, ReturnAttributeBusinessRules returnAttributeBusinessRules, IMapper mapper)
        {
            _returnAttributeRepository = returnAttributeRepository;
            _returnAttributeBusinessRules = returnAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnAttributeResponse> Handle(UpdateReturnAttributeCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnAttribute.Id)
            .CheckCodeExistenceWhenUpdate(request.ReturnAttribute.Code, request.ReturnAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.ReturnAttribute.AttributeInputTypeId);

            ReturnAttribute? currentReturnAttribute = await _returnAttributeRepository.GetAsync(predicate: x => x.Id == request.ReturnAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnAttribute? returnAttribute = _mapper.Map(request.ReturnAttribute, currentReturnAttribute);
            returnAttribute.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReturnAttributeResponse>(await _returnAttributeRepository.UpdateAsync(returnAttribute));
        }
    }
}
