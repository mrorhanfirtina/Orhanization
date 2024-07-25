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
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants.SerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetById;

public class GetByIdSerialQuery : IRequest<GetByIdSerialResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public SerialsDetailLevel DetailLevel { get; set; }



    public class GetByIdSerialQueryHandler : IRequestHandler<GetByIdSerialQuery, GetByIdSerialResponse>
    {
        private readonly ISerialRepository _serialRepository;
        private readonly SerialBusinessRules _serialBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSerialQueryHandler(ISerialRepository serialRepository, IMapper mapper, SerialBusinessRules serialBusinessRules)
        {
            _serialRepository = serialRepository;
            _mapper = mapper;
            _serialBusinessRules = serialBusinessRules;
        }

        public async Task<GetByIdSerialResponse> Handle(GetByIdSerialQuery request, CancellationToken cancellationToken)
        {
            _serialBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdSerialResponse>(await _serialRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdSerialResponse>(await _serialRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
