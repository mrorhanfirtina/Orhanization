using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;

public class UpdateStockAttributeCommand : IRequest<UpdatedStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockAttributes";

    public UpdateStockAttributeDto StockAttribute { get; set; }


    public class UpdateStockAttributeCommandHandler : IRequestHandler<UpdateStockAttributeCommand, UpdatedStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockAttributeCommandHandler(IStockAttributeRepository stockAttributeRepository, StockAttributeBusinessRules stockAttributeBusinessRules, IMapper mapper)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockAttributeResponse> Handle(UpdateStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.StockAttribute.AttributeInputTypeId)
            .CheckCodeExistenceWhenUpdate(request.StockAttribute.Code, request.StockAttribute.Id);

            StockAttribute? currentStockAttribute = await _stockAttributeRepository.GetAsync(predicate: x => x.Id == request.StockAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockAttribute? stockAttribute = _mapper.Map(request.StockAttribute, currentStockAttribute);
            stockAttribute.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockAttributeResponse>(await _stockAttributeRepository.UpdateAsync(stockAttribute));
        }
    }
}
