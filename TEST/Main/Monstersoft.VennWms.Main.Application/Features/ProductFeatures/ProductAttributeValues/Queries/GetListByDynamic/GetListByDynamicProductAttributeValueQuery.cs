﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants.ProductAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetListByDynamic;

public class GetListByDynamicProductAttributeValueQuery : IRequest<GetListResponse<GetListByDynamicProductAttributeValueListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicProductAttributeValueQueryHandler : IRequestHandler<GetListByDynamicProductAttributeValueQuery, GetListResponse<GetListByDynamicProductAttributeValueListItemDto>>
    {
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;
        private readonly ProductAttributeValueBusinessRules _productAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductAttributeValueQueryHandler(IProductAttributeValueRepository productAttributeValueRepository, IMapper mapper, ProductAttributeValueBusinessRules productAttributeValueBusinessRules)
        {
            _productAttributeValueRepository = productAttributeValueRepository;
            _productAttributeValueBusinessRules = productAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductAttributeValueListItemDto>> Handle(GetListByDynamicProductAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _productAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<ProductAttributeValue> productAttributeValueList = await _productAttributeValueRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicProductAttributeValueListItemDto>>(productAttributeValueList);
        }
    }

}
