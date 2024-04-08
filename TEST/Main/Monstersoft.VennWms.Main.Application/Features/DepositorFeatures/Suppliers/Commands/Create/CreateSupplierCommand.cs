using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants.SupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;

public class CreateSupplierCommand : IRequest<CreatedSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSuppliers";

    public CreateSupplierDto Supplier { get; set; }


    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, CreatedSupplierResponse>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;
        private readonly IMapper _mapper;

        public CreateSupplierCommandHandler(ISupplierRepository supplierRepository, SupplierBusinessRules supplierBusinessRules, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _supplierBusinessRules = supplierBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedSupplierResponse> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.CreateRequest()
            .CheckCodeExistenceWhenCreate(request.Supplier.Code)
            .CheckCompanyIdExistence(request.Supplier.CompanyId);

            Supplier supplier = _mapper.Map<Supplier>(request.Supplier);
            supplier.Id = Guid.NewGuid();
            supplier.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            supplier.CreatedDate = DateTime.Now;
            supplier.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedSupplierResponse>(await _supplierRepository.AddAsync(supplier));
        }
    }
}

