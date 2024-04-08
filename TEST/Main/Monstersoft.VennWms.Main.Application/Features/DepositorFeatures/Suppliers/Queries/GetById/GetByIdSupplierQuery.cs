using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants.SupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetById;

public class GetByIdSupplierQuery : IRequest<GetByIdSupplierResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdSupplierQueryHandler : IRequestHandler<GetByIdSupplierQuery, GetByIdSupplierResponse>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSupplierQueryHandler(ISupplierRepository supplierRepository, IMapper mapper, SupplierBusinessRules supplierBusinessRules)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
            _supplierBusinessRules = supplierBusinessRules;
        }

        public async Task<GetByIdSupplierResponse> Handle(GetByIdSupplierQuery request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdSupplierResponse>(await _supplierRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(m => m.Address),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

