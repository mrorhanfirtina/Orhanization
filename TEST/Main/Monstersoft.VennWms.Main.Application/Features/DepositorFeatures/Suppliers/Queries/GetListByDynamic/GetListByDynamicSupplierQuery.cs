using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants.SupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetListByDynamic;

public class GetListByDynamicSupplierQuery : IRequest<GetListResponse<GetListByDynamicSupplierListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicSupplierQueryHandler : IRequestHandler<GetListByDynamicSupplierQuery, GetListResponse<GetListByDynamicSupplierListItemDto>>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSupplierQueryHandler(ISupplierRepository supplierRepository, IMapper mapper, SupplierBusinessRules supplierBusinessRules)
        {
            _supplierRepository = supplierRepository;
            _supplierBusinessRules = supplierBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSupplierListItemDto>> Handle(GetListByDynamicSupplierQuery request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Supplier> supplierList = await _supplierRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicSupplierListItemDto>>(supplierList);
        }
    }

}

