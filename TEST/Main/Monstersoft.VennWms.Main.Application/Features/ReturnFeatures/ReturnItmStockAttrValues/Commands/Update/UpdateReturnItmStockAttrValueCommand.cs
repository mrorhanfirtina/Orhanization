using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;

public class UpdateReturnItmStockAttrValueCommand : IRequest<UpdatedReturnItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnItemStockAttrValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItmStockAttrValues";

    public UpdateReturnItmStockAttrValueDto ReturnItmStockAttrValue { get; set; }


    public class UpdateReturnItmStockAttrValueCommandHandler : IRequestHandler<UpdateReturnItmStockAttrValueCommand, UpdatedReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnItmStockAttrValueCommandHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules, IMapper mapper)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnItmStockAttrValueResponse> Handle(UpdateReturnItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnItmStockAttrValue.Id)
            .CheckReturnItemIdExistence(request.ReturnItmStockAttrValue.ReturnItemId)
            .CheckStockAttributeIdExistence(request.ReturnItmStockAttrValue.StockAttributeId);

            ReturnItmStockAttrValue? currentReturnItmStockAttrValue = await _returnItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.ReturnItmStockAttrValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnItmStockAttrValue? returnItmStockAttrValue = _mapper.Map(request.ReturnItmStockAttrValue, currentReturnItmStockAttrValue);
            returnItmStockAttrValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReturnItmStockAttrValueResponse>(await _returnItmStockAttrValueRepository.UpdateAsync(returnItmStockAttrValue));
        }
    }
}

