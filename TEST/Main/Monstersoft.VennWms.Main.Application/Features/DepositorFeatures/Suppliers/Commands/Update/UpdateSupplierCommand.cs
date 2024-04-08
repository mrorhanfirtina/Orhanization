using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Update;

public class UpdateSupplierCommand : IRequest<UpdatedSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, SupplierOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSuppliers";

    public UpdateSupplierDto Supplier { get; set; }


    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, UpdatedSupplierResponse>
    {
        private readonly ISupplierRepository _companyRepository;
        private readonly SupplierBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSupplierCommandHandler(ISupplierRepository companyRepository, SupplierBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedSupplierResponse> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.UpdateRequest()
                .CheckIdExistence(request.Supplier.Id)
                .CheckAddressIdExistence(request.Supplier.AddressId)
                .CheckCodeExistenceWhenUpdate(request.Supplier.Code, request.Supplier.Id)
                .CheckCompanyIdExistence(request.Supplier.CompanyId);

            Supplier currentSupplier = await _companyRepository.GetAsync(predicate: x => x.Id == request.Supplier.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Supplier? supplier = _mapper.Map(request.Supplier, currentSupplier);
            supplier.UpdatedDate = DateTime.Now;
            supplier.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedSupplierResponse>(await _companyRepository.UpdateAsync(supplier));
        }
    }
}

