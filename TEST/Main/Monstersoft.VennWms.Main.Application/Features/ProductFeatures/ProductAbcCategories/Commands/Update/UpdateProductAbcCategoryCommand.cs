using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Update;

public class UpdateProductAbcCategoryCommand : IRequest<UpdatedProductAbcCategoryResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductAbcCategoryOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetProductAbcCategories"];

    public UpdateProductAbcCategoryDto ProductAbcCategory { get; set; }
    public ProductAbcCategoriesDetailLevel DetailLevel { get; set; }


    public class UpdateProductAbcCategoryCommandHandler : IRequestHandler<UpdateProductAbcCategoryCommand, UpdatedProductAbcCategoryResponse>
    {
        private readonly IProductAbcCategoryRepository _productAbcCategoryRepository;
        private readonly ProductAbcCategoryBusinessRules _productAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductAbcCategoryCommandHandler(IProductAbcCategoryRepository productAbcCategoryRepository, ProductAbcCategoryBusinessRules productAbcCategoryBusinessRules, IMapper mapper)
        {
            _productAbcCategoryRepository = productAbcCategoryRepository;
            _productAbcCategoryBusinessRules = productAbcCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductAbcCategoryResponse> Handle(UpdateProductAbcCategoryCommand request, CancellationToken cancellationToken)
        {
            _productAbcCategoryBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductAbcCategory? currentProductAbcCategory = await _productAbcCategoryRepository.GetAsync(predicate: x => x.Id == request.ProductAbcCategory.Id);

            ProductAbcCategory? productAbcCategory = _mapper.Map(request.ProductAbcCategory, currentProductAbcCategory);
            productAbcCategory.UpdatedDate = DateTime.Now;

            await _productAbcCategoryRepository.UpdateAsync(productAbcCategory);

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

                return _mapper.Map<UpdatedProductAbcCategoryResponse>(response);
            }
            else
            {
                var response = await _productAbcCategoryRepository.GetAsync(predicate: x => x.Id == productAbcCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductAbcCategoryResponse>(response);
            }
        }
    }
}


