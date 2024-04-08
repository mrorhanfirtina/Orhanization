using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants.ProductStockAttributeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Update;

public class UpdateProductStockAttributeCommand : IRequest<UpdatedProductStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductStockAttributeOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductStockAttributes";

    public UpdateProductStockAttributeDto ProductStockAttribute { get; set; }


    public class UpdateProductStockAttributeCommandHandler : IRequestHandler<UpdateProductStockAttributeCommand, UpdatedProductStockAttributeResponse>
    {
        private readonly IProductStockAttributeRepository _productStockAttributeRepository;
        private readonly ProductStockAttributeBusinessRules _productStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductStockAttributeCommandHandler(IProductStockAttributeRepository productStockAttributeRepository, ProductStockAttributeBusinessRules productStockAttributeBusinessRules, IMapper mapper)
        {
            _productStockAttributeRepository = productStockAttributeRepository;
            _productStockAttributeBusinessRules = productStockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductStockAttributeResponse> Handle(UpdateProductStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _productStockAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ProductStockAttribute.Id)
            .CheckProductIdExistence(request.ProductStockAttribute.ProductId)
            .CheckStockAttributeIdExistence(request.ProductStockAttribute.StockAttributeId);

            ProductStockAttribute? currentProductStockAttribute = await _productStockAttributeRepository.GetAsync(predicate: x => x.Id == request.ProductStockAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ProductStockAttribute? productStockAttribute = _mapper.Map(request.ProductStockAttribute, currentProductStockAttribute);
            productStockAttribute.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedProductStockAttributeResponse>(await _productStockAttributeRepository.UpdateAsync(productStockAttribute));
        }
    }
}

