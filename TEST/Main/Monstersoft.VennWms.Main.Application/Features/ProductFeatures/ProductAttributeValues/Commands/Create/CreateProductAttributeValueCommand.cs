using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants.ProductAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;

public class CreateProductAttributeValueCommand : IRequest<CreatedProductAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductAttributeValues";

    public CreateProductAttributeValueDto ProductAttributeValue { get; set; }


    public class CreateProductAttributeValueCommandHandler : IRequestHandler<CreateProductAttributeValueCommand, CreatedProductAttributeValueResponse>
    {
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;
        private readonly ProductAttributeValueBusinessRules _productAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductAttributeValueCommandHandler(IProductAttributeValueRepository productAttributeValueRepository, IMapper mapper, ProductAttributeValueBusinessRules productAttributeValueBusinessRules)
        {
            _productAttributeValueRepository = productAttributeValueRepository;
            _mapper = mapper;
            _productAttributeValueBusinessRules = productAttributeValueBusinessRules;
        }

        public async Task<CreatedProductAttributeValueResponse> Handle(CreateProductAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _productAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckProductAttributeIdExistence(request.ProductAttributeValue.ProductAttributeId)
                .CheckProductIdExistence(request.ProductAttributeValue.ProductId);

            ProductAttributeValue productAttributeValue = _mapper.Map<ProductAttributeValue>(request.ProductAttributeValue);
            productAttributeValue.Id = Guid.NewGuid();
            productAttributeValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedProductAttributeValueResponse>(await _productAttributeValueRepository.AddAsync(productAttributeValue));
        }
    }
}

