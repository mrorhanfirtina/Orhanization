using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants.ExpectedSerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetListByDynamic;

public class GetListByDynamicExpectedSerialQuery : IRequest<GetListResponse<GetListByDynamicExpectedSerialListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ExpectedSerialsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicExpectedSerialQueryHandler : IRequestHandler<GetListByDynamicExpectedSerialQuery, GetListResponse<GetListByDynamicExpectedSerialListItemDto>>
    {
        private readonly IExpectedSerialRepository _expectedSerialRepository;
        private readonly ExpectedSerialBusinessRules _expectedSerialBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicExpectedSerialQueryHandler(IExpectedSerialRepository expectedSerialRepository, IMapper mapper, ExpectedSerialBusinessRules expectedSerialBusinessRules)
        {
            _expectedSerialRepository = expectedSerialRepository;
            _expectedSerialBusinessRules = expectedSerialBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicExpectedSerialListItemDto>> Handle(GetListByDynamicExpectedSerialQuery request, CancellationToken cancellationToken)
        {
            _expectedSerialBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<ExpectedSerial> expectedSerialList = await _expectedSerialRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ExpectedSerial> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(x => x.Receipt);
                    }

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(x => x.ReceiptItem);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(x => x.ItemUnit);

                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(x => x.ItemUnit).ThenInclude(x => x.Product);
                        }

                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(x => x.ItemUnit).ThenInclude(x => x.Unit);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(x => x.Depositor);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ExpectedSerial, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicExpectedSerialListItemDto>>(expectedSerialList);
            }
            else
            {
                Paginate<ExpectedSerial> expectedSerialList = await _expectedSerialRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicExpectedSerialListItemDto>>(expectedSerialList);
            }
        }
    }
}
