using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants.SerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetListByDynamic;

public class GetListByDynamicSerialQuery : IRequest<GetListResponse<GetListByDynamicSerialListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public SerialsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicSerialQueryHandler : IRequestHandler<GetListByDynamicSerialQuery, GetListResponse<GetListByDynamicSerialListItemDto>>
    {
        private readonly ISerialRepository _serialRepository;
        private readonly SerialBusinessRules _serialBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSerialQueryHandler(ISerialRepository serialRepository, IMapper mapper, SerialBusinessRules serialBusinessRules)
        {
            _serialRepository = serialRepository;
            _serialBusinessRules = serialBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSerialListItemDto>> Handle(GetListByDynamicSerialQuery request, CancellationToken cancellationToken)
        {
            _serialBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<Serial> serialList = await _serialRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<Serial> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(x => x.Depositor);
                    }

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(x => x.Receipt);
                    }

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(x => x.ReceiptItem);
                    }

                    if (detailLevel.IncludeStockPackType)
                    {
                        query = query.Include(x => x.StockPackType);

                        if (detailLevel.StockPackTypeDetailLevel.IncludeItemUnit)
                        {
                            query = query.Include(x => x.StockPackType).ThenInclude(x => x.ItemUnit);

                            if (detailLevel.StockPackTypeDetailLevel.ItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(x => x.StockPackType).ThenInclude(x => x.ItemUnit).ThenInclude(x => x.Unit);
                            }
                        }

                        if (detailLevel.StockPackTypeDetailLevel.IncludeStock)
                        {
                            query = query.Include(x => x.StockPackType).ThenInclude(x => x.Stock);

                            if (detailLevel.StockPackTypeDetailLevel.StockDetailLevel.IncludeLocation)
                            {
                                query = query.Include(x => x.StockPackType).ThenInclude(x => x.Stock).ThenInclude(x => x.Location);
                            }

                            if (detailLevel.StockPackTypeDetailLevel.StockDetailLevel.IncludeStockContainer)
                            {
                                query = query.Include(x => x.StockPackType).ThenInclude(x => x.Stock).ThenInclude(x => x.StockContainer);
                            }
                        }
                    }

                    if (detailLevel.IncludeSerialHiearchy)
                    {
                        query = query.Include(x => x.SerialHierarchies);

                        if (detailLevel.SerialHiearchyDetailLevel.IncludeChildSerial)
                        {
                            query = query.Include(x => x.SerialHierarchies).ThenInclude(x => x.ChildSerial);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<Serial, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialListItemDto>>(serialList);
            }
            else
            {
                Paginate<Serial> serialList = await _serialRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSerialListItemDto>>(serialList);
            }
        }
    }
}
