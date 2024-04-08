using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants.ProductBarcodeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetById;

public class GetByIdProductBarcodeQuery : IRequest<GetByIdProductBarcodeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductBarcodeQueryHandler : IRequestHandler<GetByIdProductBarcodeQuery, GetByIdProductBarcodeResponse>
    {
        private readonly IProductBarcodeRepository _productBarcodeRepository;
        private readonly ProductBarcodeBusinessRules _productBarcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductBarcodeQueryHandler(IProductBarcodeRepository productBarcodeRepository, IMapper mapper, ProductBarcodeBusinessRules productBarcodeBusinessRules)
        {
            _productBarcodeRepository = productBarcodeRepository;
            _mapper = mapper;
            _productBarcodeBusinessRules = productBarcodeBusinessRules;
        }

        public async Task<GetByIdProductBarcodeResponse> Handle(GetByIdProductBarcodeQuery request, CancellationToken cancellationToken)
        {
            _productBarcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductBarcodeResponse>(await _productBarcodeRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.BarcodeSuppliers),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}


