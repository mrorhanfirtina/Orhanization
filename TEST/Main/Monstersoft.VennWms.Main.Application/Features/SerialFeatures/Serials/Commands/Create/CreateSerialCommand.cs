using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Constants.SerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Create;

public class CreateSerialCommand : IRequest<CreatedSerialResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerials"];

    public CreateSerialDto Serial { get; set; }
    public SerialsDetailLevel DetailLevel { get; set; }

    public class CreateSerialCommandHandler : IRequestHandler<CreateSerialCommand, CreatedSerialResponse>
    {
        private readonly ISerialRepository _serialRepository;
        private readonly SerialBusinessRules _serialBusinessRules;
        private readonly IMapper _mapper;

        public CreateSerialCommandHandler(ISerialRepository serialRepository, IMapper mapper, SerialBusinessRules serialBusinessRules)
        {
            _serialRepository = serialRepository;
            _mapper = mapper;
            _serialBusinessRules = serialBusinessRules;
        }

        public async Task<CreatedSerialResponse> Handle(CreateSerialCommand request, CancellationToken cancellationToken)
        {
            _serialBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            Serial serial = _mapper.Map<Serial>(request.Serial);
            serial.Id = Guid.NewGuid();
            serial.CreatedDate = DateTime.Now;

            await _serialRepository.AddAsync(serial);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _serialRepository.GetAsync(predicate: x => x.Id == serial.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSerialResponse>(response);
            }
            else
            {
                var response = await _serialRepository.GetAsync(predicate: x => x.Id == serial.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSerialResponse>(response);
            }
        }
    }
}
