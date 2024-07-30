using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants.ProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Create;

public class CreateProductAbcCategoryCommand : IRequest<CreatedProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductAbcCategories"];


    public CreateProductAbcCategoryDto ProductAbcCategory { get; set; }
    public ProductAbcCategoriesDetailLevel DetailLevel { get; set; }



    public class CreateProductAbcCategoryCommandHandler : IRequestHandler<CreateProductAbcCategoryCommand, CreatedProductAbcCategoryResponse>
    {
        private readonly IProductAbcCategoryRepository _productAbcCategoryRepository;
        private readonly ProductAbcCategoryBusinessRules _productAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductAbcCategoryCommandHandler(IProductAbcCategoryRepository productAbcCategoryRepository, IMapper mapper, ProductAbcCategoryBusinessRules productAbcCategoryBusinessRules)
        {
            _productAbcCategoryRepository = productAbcCategoryRepository;
            _mapper = mapper;
            _productAbcCategoryBusinessRules = productAbcCategoryBusinessRules;
        }

        public async Task<CreatedProductAbcCategoryResponse> Handle(CreateProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _productAbcCategoryBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductAbcCategory productAbcCategory = _mapper.Map<ProductAbcCategory>(request.ProductAbcCategory);
            productAbcCategory.Id = Guid.NewGuid();
            productAbcCategory.CreatedDate = DateTime.Now;

            await _productAbcCategoryRepository.AddAsync(productAbcCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productAbcCategoryRepository.GetAsync(predicate: x => x.Id == productAbcCategory.Id,
                include: x =>
                {
                    IQueryable<ProductAbcCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAbcCategoryList)
                    {
                        query = query.Include(y => y.AbcCategory);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }


                    var includableQuery = query as IIncludableQueryable<ProductAbcCategory, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductAbcCategoryResponse>(response);
            }
            else
            {
                var response = await _productAbcCategoryRepository.GetAsync(predicate: x => x.Id == productAbcCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductAbcCategoryResponse>(response);
            }
        }
    }
}


