using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants.ProductDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Queries.GetListByDynamic;

public class GetListByDynamicProductDepositorQuery : IRequest<GetListResponse<GetListByDynamicProductDepositorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ProductDepositorDetailLevel DetailLevel { get; set; }



    public class GetListByDynamicProductDepositorQueryHandler : IRequestHandler<GetListByDynamicProductDepositorQuery, GetListResponse<GetListByDynamicProductDepositorListItemDto>>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicProductDepositorQueryHandler(IProductDepositorRepository productDepositorRepository, IMapper mapper, ProductDepositorBusinessRules productDepositorBusinessRules)
        {
            _productDepositorRepository = productDepositorRepository;
            _productDepositorBusinessRules = productDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicProductDepositorListItemDto>> Handle(GetListByDynamicProductDepositorQuery request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ProductDepositor> productDepositorList = await _productDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ProductDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductDepositor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductDepositorListItemDto>>(productDepositorList);
            }
            else
            {
                Paginate<ProductDepositor> productDepositorList = await _productDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicProductDepositorListItemDto>>(productDepositorList);
            }
        }
    }

}


