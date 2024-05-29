using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Constants.ProductCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Create;

public class CreateProductCategoryCommand : IRequest<CreatedProductCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductCategories";

    public CreateProductCategoryDto ProductCategory { get; set; }
    public ProductCategoryDetailLevel DetailLevel { get; set; }



    public class CreateProductCategoryCommandHandler : IRequestHandler<CreateProductCategoryCommand, CreatedProductCategoryResponse>
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        private readonly ProductCategoryBusinessRules _productCategoryBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductCategoryCommandHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper, ProductCategoryBusinessRules productCategoryBusinessRules)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
            _productCategoryBusinessRules = productCategoryBusinessRules;
        }

        public async Task<CreatedProductCategoryResponse> Handle(CreateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            _productCategoryBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategory productCategory = _mapper.Map<ProductCategory>(request.ProductCategory);
            productCategory.Id = Guid.NewGuid();
            productCategory.CreatedDate = DateTime.Now;

            await _productCategoryRepository.AddAsync(productCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productCategoryRepository.GetAsync(predicate: x => x.Id == productCategory.Id,
                include: x =>
                {
                    IQueryable<ProductCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeCategory)
                    {
                        query = query.Include(y => y.Category);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductCategory, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductCategoryResponse>(response);
            }
            else
            {
                var response = await _productCategoryRepository.GetAsync(predicate: x => x.Id == productCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductCategoryResponse>(response);
            }
        }
    }
}

