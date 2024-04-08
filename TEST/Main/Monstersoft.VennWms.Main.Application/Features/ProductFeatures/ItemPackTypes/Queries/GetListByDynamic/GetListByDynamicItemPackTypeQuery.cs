using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetListByDynamic;

public class GetListByDynamicItemPackTypeQuery : IRequest<GetListResponse<GetListByDynamicItemPackTypeListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicItemPackTypeQueryHandler : IRequestHandler<GetListByDynamicItemPackTypeQuery, GetListResponse<GetListByDynamicItemPackTypeListItemDto>>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicItemPackTypeQueryHandler(IItemPackTypeRepository itemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules itemPackTypeBusinessRules)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicItemPackTypeListItemDto>> Handle(GetListByDynamicItemPackTypeQuery request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ItemPackType> itemPackTypeList = await _itemPackTypeRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicItemPackTypeListItemDto>>(itemPackTypeList);
        }
    }

}
