using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Constants.ProductOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetByCode;

public class GetByCodeProductQuery : IRequest<GetByCodeProductResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }

    public class GetByCodeProductQueryHandler : IRequestHandler<GetByCodeProductQuery, GetByCodeProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductBusinessRules _productBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeProductQueryHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<GetByCodeProductResponse> Handle(GetByCodeProductQuery request, CancellationToken cancellationToken)
        {
            _productBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeProductResponse>(await _productRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.ProductAttributeValues)
            .Include(x => x.ProductBarcodes).ThenInclude(pb => pb.BarcodeSuppliers)
            .Include(x => x.ItemUnits).ThenInclude(iu => iu.ItemPackTypes),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
