using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Constants.ProductCategoryListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetById;

public class GetByIdProductCategoryListQuery : IRequest<GetByIdProductCategoryListResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public int Id { get; set; }
    public ProductCategoryListsDetailLevel DetailLevel { get; set; }


    public class GetByIdProductCategoryListQueryHandler : IRequestHandler<GetByIdProductCategoryListQuery, GetByIdProductCategoryListResponse>
    {
        private readonly IProductCategoryListRepository _productCategoryListRepository;
        private readonly ProductCategoryListBusinessRules _productCategoryListBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductCategoryListQueryHandler(IProductCategoryListRepository productCategoryListRepository, IMapper mapper, ProductCategoryListBusinessRules productCategoryListBusinessRules)
        {
            _productCategoryListRepository = productCategoryListRepository;
            _mapper = mapper;
            _productCategoryListBusinessRules = productCategoryListBusinessRules;
        }

        public async Task<GetByIdProductCategoryListResponse> Handle(GetByIdProductCategoryListQuery request, CancellationToken cancellationToken)
        {
            _productCategoryListBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdProductCategoryListResponse>(await _productCategoryListRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdProductCategoryListResponse>(await _productCategoryListRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}


