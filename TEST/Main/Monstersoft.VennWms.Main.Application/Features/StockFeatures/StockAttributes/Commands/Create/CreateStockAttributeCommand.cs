using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Create;

public class CreateStockAttributeCommand : IRequest<CreatedStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockAttributes";

    public CreateStockAttributeDto StockAttribute { get; set; }


    public class CreateStockAttributeCommandHandler : IRequestHandler<CreateStockAttributeCommand, CreatedStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockAttributeCommandHandler(IStockAttributeRepository stockAttributeRepository, IMapper mapper, StockAttributeBusinessRules stockAttributeBusinessRules)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _mapper = mapper;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
        }

        public async Task<CreatedStockAttributeResponse> Handle(CreateStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckAttributeInputTypeIdExistence(request.StockAttribute.AttributeInputTypeId)
                .CheckCodeExistenceWhenCreate(request.StockAttribute.Code);

            StockAttribute stockAttribute = _mapper.Map<StockAttribute>(request.StockAttribute);
            stockAttribute.Id = Guid.NewGuid();
            stockAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            stockAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockAttributeResponse>(await _stockAttributeRepository.AddAsync(stockAttribute));
        }
    }
}
