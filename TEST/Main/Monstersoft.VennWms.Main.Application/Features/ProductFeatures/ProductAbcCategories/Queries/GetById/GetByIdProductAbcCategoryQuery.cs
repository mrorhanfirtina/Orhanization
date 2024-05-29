using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Constants.ProductAbcCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetById;

public class GetByIdProductAbcCategoryQuery : IRequest<GetByIdProductAbcCategoryResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ProductAbcCategoryDetailLevel DetailLevel { get; set; }


    public class GetByIdProductAbcCategoryQueryHandler : IRequestHandler<GetByIdProductAbcCategoryQuery, GetByIdProductAbcCategoryResponse>
    {
        private readonly IProductAbcCategoryRepository _productAbcCategoryRepository;
        private readonly ProductAbcCategoryBusinessRules _productAbcCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductAbcCategoryQueryHandler(IProductAbcCategoryRepository productAbcCategoryRepository, IMapper mapper, ProductAbcCategoryBusinessRules productAbcCategoryBusinessRules)
        {
            _productAbcCategoryRepository = productAbcCategoryRepository;
            _mapper = mapper;
            _productAbcCategoryBusinessRules = productAbcCategoryBusinessRules;
        }

        public async Task<GetByIdProductAbcCategoryResponse> Handle(GetByIdProductAbcCategoryQuery request, CancellationToken cancellationToken)
        {
            _productAbcCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdProductAbcCategoryResponse>(await _productAbcCategoryRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdProductAbcCategoryResponse>(await _productAbcCategoryRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}


