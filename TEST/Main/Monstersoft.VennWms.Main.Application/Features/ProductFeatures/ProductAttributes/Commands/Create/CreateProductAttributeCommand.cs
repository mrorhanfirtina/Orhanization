using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants.ProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;

public class CreateProductAttributeCommand : IRequest<CreatedProductAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductAttributes";

    public CreateProductAttributeDto ProductAttribute { get; set; }


    public class CreateProductAttributeCommandHandler : IRequestHandler<CreateProductAttributeCommand, CreatedProductAttributeResponse>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductAttributeCommandHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper, ProductAttributeBusinessRules productAttributeBusinessRules)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
            _productAttributeBusinessRules = productAttributeBusinessRules;
        }

        public async Task<CreatedProductAttributeResponse> Handle(CreateProductAttributeCommand request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ProductAttribute.Code);

            ProductAttribute productAttribute = _mapper.Map<ProductAttribute>(request.ProductAttribute);
            productAttribute.Id = Guid.NewGuid();
            productAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            productAttribute.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedProductAttributeResponse>(await _productAttributeRepository.AddAsync(productAttribute));
        }
    }
}
