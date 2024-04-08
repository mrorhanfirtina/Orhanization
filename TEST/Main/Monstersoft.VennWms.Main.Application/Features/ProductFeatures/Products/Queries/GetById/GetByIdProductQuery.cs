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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetById;

public class GetByIdProductQuery : IRequest<GetByIdProductResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductBusinessRules _productBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductQueryHandler(IProductRepository productRepository, IMapper mapper, ProductBusinessRules productBusinessRules)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productBusinessRules = productBusinessRules;
        }

        public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            _productBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductResponse>(await _productRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.ProductAttributeValues)
                .Include(x => x.ProductBarcodes).ThenInclude(pb => pb.BarcodeSuppliers)
                .Include(x => x.ItemUnits).ThenInclude(iu => iu.ItemPackTypes),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
