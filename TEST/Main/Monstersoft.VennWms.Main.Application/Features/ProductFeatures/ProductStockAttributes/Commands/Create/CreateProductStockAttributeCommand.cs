using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants.ProductStockAttributeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;

public class CreateProductStockAttributeCommand : IRequest<CreatedProductStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductStockAttributes";

    public CreateProductStockAttributeDto ProductStockAttribute { get; set; }
    public ProductStockAttributeDetailLevel DetailLevel { get; set; }



    public class CreateProductStockAttributeCommandHandler : IRequestHandler<CreateProductStockAttributeCommand, CreatedProductStockAttributeResponse>
    {
        private readonly IProductStockAttributeRepository _productStockAttributeRepository;
        private readonly ProductStockAttributeBusinessRules _productStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductStockAttributeCommandHandler(IProductStockAttributeRepository productStockAttributeRepository, IMapper mapper, ProductStockAttributeBusinessRules productStockAttributeBusinessRules)
        {
            _productStockAttributeRepository = productStockAttributeRepository;
            _mapper = mapper;
            _productStockAttributeBusinessRules = productStockAttributeBusinessRules;
        }

        public async Task<CreatedProductStockAttributeResponse> Handle(CreateProductStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _productStockAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckProductIdExistence(request.ProductStockAttribute.ProductId)
                .CheckStockAttributeIdExistence(request.ProductStockAttribute.StockAttributeId);

            ProductStockAttribute productStockAttribute = _mapper.Map<ProductStockAttribute>(request.ProductStockAttribute);
            productStockAttribute.Id = Guid.NewGuid();
            productStockAttribute.CreatedDate = DateTime.Now;

            await _productStockAttributeRepository.AddAsync(productStockAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productStockAttributeRepository.GetAsync(predicate: x => x.Id == productStockAttribute.Id,
                include: x =>
                {
                    IQueryable<ProductStockAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        if (detailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<ProductStockAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductStockAttributeResponse>(response);
            }
            else
            {
                var response = await _productStockAttributeRepository.GetAsync(predicate: x => x.Id == productStockAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductStockAttributeResponse>(response);
            }
        }
    }
}

