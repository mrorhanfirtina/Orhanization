using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;

public class UpdateReturnAttributeValueCommand : IRequest<UpdatedReturnAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributeValues";

    public UpdateReturnAttributeValueDto ReturnAttributeValue { get; set; }


    public class UpdateReturnAttributeValueCommandHandler : IRequestHandler<UpdateReturnAttributeValueCommand, UpdatedReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnAttributeValueCommandHandler(IReturnAttributeValueRepository returnAttributeValueRepository, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules, IMapper mapper)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnAttributeValueResponse> Handle(UpdateReturnAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnAttributeValue.Id)
            .CheckReturnAttributeIdExistence(request.ReturnAttributeValue.ReturnAttributeId)
            .CheckReturnIdExistence(request.ReturnAttributeValue.ReturnId);

            ReturnAttributeValue? currentReturnAttributeValue = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == request.ReturnAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnAttributeValue? returnAttributeValue = _mapper.Map(request.ReturnAttributeValue, currentReturnAttributeValue);
            returnAttributeValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReturnAttributeValueResponse>(await _returnAttributeValueRepository.UpdateAsync(returnAttributeValue));
        }
    }
}

