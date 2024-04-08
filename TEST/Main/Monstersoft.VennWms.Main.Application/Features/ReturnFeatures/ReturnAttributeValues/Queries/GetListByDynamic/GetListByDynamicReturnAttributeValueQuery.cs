using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicReturnAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicReturnAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicReturnAttributeValueQueryHandler : IRequestHandler<GetListByDynamicReturnAttributeValueQuery, GetListResponse<GetListByDynamicReturnAttributeValueListItemDto>>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicReturnAttributeValueQueryHandler(IReturnAttributeValueRepository returnAttributeValueRepository, IMapper mapper, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicReturnAttributeValueListItemDto>> Handle(GetListByDynamicReturnAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ReturnAttributeValue> returnAttributeValueList = await _returnAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicReturnAttributeValueListItemDto>>(returnAttributeValueList);
        }
    }


}

