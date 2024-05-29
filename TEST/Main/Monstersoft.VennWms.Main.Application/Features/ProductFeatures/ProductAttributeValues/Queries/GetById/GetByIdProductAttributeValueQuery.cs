using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants.ProductAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetById;

public class GetByIdProductAttributeValueQuery : IRequest<GetByIdProductAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ProductAttributeValueDetailLevel DetailLevel { get; set; }



    public class GetByIdProductAttributeValueQueryHandler : IRequestHandler<GetByIdProductAttributeValueQuery, GetByIdProductAttributeValueResponse>
    {
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;
        private readonly ProductAttributeValueBusinessRules _productAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductAttributeValueQueryHandler(IProductAttributeValueRepository productAttributeValueRepository, IMapper mapper, ProductAttributeValueBusinessRules productAttributeValueBusinessRules)
        {
            _productAttributeValueRepository = productAttributeValueRepository;
            _mapper = mapper;
            _productAttributeValueBusinessRules = productAttributeValueBusinessRules;
        }

        public async Task<GetByIdProductAttributeValueResponse> Handle(GetByIdProductAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _productAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdProductAttributeValueResponse>(await _productAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ProductAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeProductAttribute)
                    {
                        query = query.Include(y => y.ProductAttribute);

                        if (detailLevel.ProductAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ProductAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<ProductAttributeValue, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdProductAttributeValueResponse>(await _productAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

