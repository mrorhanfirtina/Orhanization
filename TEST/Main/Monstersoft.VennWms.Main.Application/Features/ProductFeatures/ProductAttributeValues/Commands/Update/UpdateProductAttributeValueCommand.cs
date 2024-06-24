using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants.ProductAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Update;

public class UpdateProductAttributeValueCommand : IRequest<UpdatedProductAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ProductAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductAttributeValues";

    public UpdateProductAttributeValueDto ProductAttributeValue { get; set; }
    public ProductAttributeValuesDetailLevel DetailLevel { get; set; }



    public class UpdateProductAttributeValueCommandHandler : IRequestHandler<UpdateProductAttributeValueCommand, UpdatedProductAttributeValueResponse>
    {
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;
        private readonly ProductAttributeValueBusinessRules _productAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductAttributeValueCommandHandler(IProductAttributeValueRepository productAttributeValueRepository, ProductAttributeValueBusinessRules productAttributeValueBusinessRules, IMapper mapper)
        {
            _productAttributeValueRepository = productAttributeValueRepository;
            _productAttributeValueBusinessRules = productAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductAttributeValueResponse> Handle(UpdateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _productAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ProductAttributeValue.Id)
            .CheckProductAttributeIdExistence(request.ProductAttributeValue.ProductAttributeId)
            .CheckProductIdExistence(request.ProductAttributeValue.ProductId);

            ProductAttributeValue? currentProductAttributeValue = await _productAttributeValueRepository.GetAsync(predicate: x => x.Id == request.ProductAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ProductAttributeValue? productAttributeValue = _mapper.Map(request.ProductAttributeValue, currentProductAttributeValue);
            productAttributeValue.UpdatedDate = DateTime.Now;

            await _productAttributeValueRepository.UpdateAsync(productAttributeValue);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productAttributeValueRepository.GetAsync(predicate: x => x.Id == productAttributeValue.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductAttributeValueResponse>(response);
            }
            else
            {
                var response = await _productAttributeValueRepository.GetAsync(predicate: x => x.Id == productAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductAttributeValueResponse>(response);
            }
        }
    }
}

