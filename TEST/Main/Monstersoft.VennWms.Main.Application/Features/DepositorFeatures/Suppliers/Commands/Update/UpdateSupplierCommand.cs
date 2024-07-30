using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public string[]? CacheGroupKey => ["GetSuppliers"];

    public UpdateSupplierDto Supplier { get; set; }
    public SuppliersDetailLevel DetailLevel { get; set; }


    public class UpdateSupplierCommandHandler : IRequestHandler<UpdateSupplierCommand, UpdatedSupplierResponse>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSupplierCommandHandler(ISupplierRepository supplierRepository, SupplierBusinessRules supplierBusinessRules, IMapper mapper)
        {
            _supplierRepository = supplierRepository;
            _supplierBusinessRules = supplierBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedSupplierResponse> Handle(UpdateSupplierCommand request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckIdExistence(request.Supplier.Id)
                .CheckCodeExistenceWhenUpdate(request.Supplier.Code, request.Supplier.Id)
                .CheckCompanyIdExistence(request.Supplier.CompanyId);

            Supplier currentSupplier = await _supplierRepository.GetAsync(predicate: x => x.Id == request.Supplier.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Supplier? supplier = _mapper.Map(request.Supplier, currentSupplier);
            supplier.UpdatedDate = DateTime.Now;
            supplier.Address.UpdatedDate = DateTime.Now;

            await _supplierRepository.UpdateAsync(supplier);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _supplierRepository.GetAsync(predicate: x => x.Id == supplier.Id,
                include: x =>
                {
                    IQueryable<Supplier> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);
                    }

                    var includableQuery = query as IIncludableQueryable<Supplier, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSupplierResponse>(response);
            }
            else
            {
                var response = await _supplierRepository.GetAsync(predicate: x => x.Id == supplier.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSupplierResponse>(response);
            }
        }
    }
}

