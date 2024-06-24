using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants.ProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Update;

public class UpdateProductAttributeCommand : IRequest<UpdatedProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ProductAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductAttributes";

    public UpdateProductAttributeDto ProductAttribute { get; set; }
    public ProductAttributesDetailLevel DetailLevel { get; set; }



    public class UpdateProductAttributeCommandHandler : IRequestHandler<UpdateProductAttributeCommand, UpdatedProductAttributeResponse>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository, ProductAttributeBusinessRules productAttributeBusinessRules, IMapper mapper)
        {
            _productAttributeRepository = productAttributeRepository;
            _productAttributeBusinessRules = productAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductAttributeResponse> Handle(UpdateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ProductAttribute.Id)
            .CheckCodeExistenceWhenUpdate(request.ProductAttribute.Code, request.ProductAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.ProductAttribute.AttributeInputTypeId);

            ProductAttribute? currentProductAttribute = await _productAttributeRepository.GetAsync(predicate: x => x.Id == request.ProductAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ProductAttribute? productAttribute = _mapper.Map(request.ProductAttribute, currentProductAttribute);
            productAttribute.UpdatedDate = DateTime.Now;

            await _productAttributeRepository.UpdateAsync(productAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productAttributeRepository.GetAsync(predicate: x => x.Id == productAttribute.Id,
                include: x =>
                {
                    IQueryable<ProductAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }


                    var includableQuery = query as IIncludableQueryable<ProductAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductAttributeResponse>(response);
            }
            else
            {
                var response = await _productAttributeRepository.GetAsync(predicate: x => x.Id == productAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductAttributeResponse>(response);
            }
        }
    }
}
