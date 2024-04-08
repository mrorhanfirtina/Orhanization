using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants.SupplierOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetList;

public class GetListSupplierQuery : IRequest<GetListResponse<GetListSupplierListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListSupplierQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetSuppliers";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListSupplierQueryHandler : IRequestHandler<GetListSupplierQuery, GetListResponse<GetListSupplierListItemDto>>
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierBusinessRules _supplierBusinessRules;
        private readonly IMapper _mapper;

        public GetListSupplierQueryHandler(ISupplierRepository supplierRepository, IMapper mapper, SupplierBusinessRules supplierBusinessRules)
        {
            _supplierRepository = supplierRepository;
            _mapper = mapper;
            _supplierBusinessRules = supplierBusinessRules;
        }

        public async Task<GetListResponse<GetListSupplierListItemDto>> Handle(GetListSupplierQuery request, CancellationToken cancellationToken)
        {
            _supplierBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Supplier> supplierList = await _supplierRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListSupplierListItemDto>>(supplierList);
        }
    }

}

