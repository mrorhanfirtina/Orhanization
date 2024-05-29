using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants.ProductCategoryListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Create;

public class CreateProductCategoryListCommand : IRequest<CreatedProductCategoryListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductCategoryLists";

    public CreateProductCategoryListDto ProductCategoryList { get; set; }
    public ProductCategoryListDetailLevel DetailLevel { get; set; }



    public class CreateProductCategoryListCommandHandler : IRequestHandler<CreateProductCategoryListCommand, CreatedProductCategoryListResponse>
    {
        private readonly IProductCategoryListRepository _productCategoryListRepository;
        private readonly ProductCategoryListBusinessRules _productCategoryListBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductCategoryListCommandHandler(IProductCategoryListRepository productCategoryListRepository, IMapper mapper, ProductCategoryListBusinessRules productCategoryListBusinessRules)
        {
            _productCategoryListRepository = productCategoryListRepository;
            _mapper = mapper;
            _productCategoryListBusinessRules = productCategoryListBusinessRules;
        }

        public async Task<CreatedProductCategoryListResponse> Handle(CreateProductCategoryListCommand request, CancellationToken cancellationToken)
        {
            _productCategoryListBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategoryList productCategoryList = _mapper.Map<ProductCategoryList>(request.ProductCategoryList);
            productCategoryList.CreatedDate = DateTime.Now;


            ProductCategoryList addedProductCategoryList = await _productCategoryListRepository.AddAsync(productCategoryList);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == addedProductCategoryList.Id,
                include: x =>
                {
                    IQueryable<ProductCategoryList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductCategoryList, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductCategoryListResponse>(response);
            }
            else
            {
                var response = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == addedProductCategoryList.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductCategoryListResponse>(response);
            }
        }
    }
}


