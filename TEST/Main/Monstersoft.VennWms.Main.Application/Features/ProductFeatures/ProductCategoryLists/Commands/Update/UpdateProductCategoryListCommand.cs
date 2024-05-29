using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Update;

public class UpdateProductCategoryListCommand : IRequest<UpdatedProductCategoryListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductCategoryListOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductCategoryLists";

    public UpdateProductCategoryListDto ProductCategoryList { get; set; }
    public ProductCategoryListDetailLevel DetailLevel { get; set; }


    public class UpdateProductCategoryListCommandHandler : IRequestHandler<UpdateProductCategoryListCommand, UpdatedProductCategoryListResponse>
    {
        private readonly IProductCategoryListRepository _productCategoryListRepository;
        private readonly ProductCategoryListBusinessRules _productCategoryListBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductCategoryListCommandHandler(IProductCategoryListRepository productCategoryListRepository, ProductCategoryListBusinessRules productCategoryListBusinessRules, IMapper mapper)
        {
            _productCategoryListRepository = productCategoryListRepository;
            _productCategoryListBusinessRules = productCategoryListBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductCategoryListResponse> Handle(UpdateProductCategoryListCommand request, CancellationToken cancellationToken)
        {
            _productCategoryListBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ProductCategoryList? currentProductCategoryList = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == request.ProductCategoryList.Id);

            ProductCategoryList? productCategoryList = _mapper.Map(request.ProductCategoryList, currentProductCategoryList);
            productCategoryList.UpdatedDate = DateTime.Now;

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == productCategoryList.Id,
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

                return _mapper.Map<UpdatedProductCategoryListResponse>(response);
            }
            else
            {
                var response = await _productCategoryListRepository.GetAsync(predicate: x => x.Id == productCategoryList.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductCategoryListResponse>(response);
            }
        }
    }
}


