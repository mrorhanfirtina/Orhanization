using MediatR;
using Microsoft.EntityFrameworkCore;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Delete;

public class DeleteSupplierCommand : IRequest<DeletedSupplierResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, SupplierOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSuppliers"];

    public Guid Id { get; set; }


    public class DeleteSupplierCommandHandler : IRequestHandler<DeleteSupplierCommand, DeletedSupplierResponse>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;

        public DeleteSupplierCommandHandler(ISupplierRepository supplierRepository, SupplierBusinessRules supplierBusinessRules)
        {
            _supplierRepository = supplierRepository;
            _supplierBusinessRules = supplierBusinessRules;
        }

        public async Task<DeletedSupplierResponse> Handle(DeleteSupplierCommand request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Supplier? supplier = await _supplierRepository.GetAsync(predicate: x => x.Id == request.Id && !x.DeletedDate.HasValue,
            include: x => x.Include(y => y.Address),
            enableTracking: true,
            cancellationToken: cancellationToken);

            supplier.Address.DeletedDate = DateTime.Now;

            await _supplierRepository.DeleteAsync(supplier);

            return new DeletedSupplierResponse
            {
                Id = supplier.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = SupplierMessages.RequestExecutedSuccessfully
            };
        }
    }

}

