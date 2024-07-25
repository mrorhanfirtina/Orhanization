using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants.ExpectedSerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Create;

public class CreateExpectedSerialCommand : IRequest<CreatedExpectedSerialResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerials"];

    public CreateExpectedSerialDto ExpectedSerial { get; set; }
    public ExpectedSerialsDetailLevel DetailLevel { get; set; }

    public class CreateExpectedSerialCommandHandler : IRequestHandler<CreateExpectedSerialCommand, CreatedExpectedSerialResponse>
    {
        private readonly IExpectedSerialRepository _expectedSerialRepository;
        private readonly ExpectedSerialBusinessRules _expectedSerialBusinessRules;
        private readonly IMapper _mapper;

        public CreateExpectedSerialCommandHandler(IExpectedSerialRepository expectedSerialRepository, IMapper mapper, ExpectedSerialBusinessRules expectedSerialBusinessRules)
        {
            _expectedSerialRepository = expectedSerialRepository;
            _mapper = mapper;
            _expectedSerialBusinessRules = expectedSerialBusinessRules;
        }

        public async Task<CreatedExpectedSerialResponse> Handle(CreateExpectedSerialCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            ExpectedSerial expectedSerial = _mapper.Map<ExpectedSerial>(request.ExpectedSerial);
            expectedSerial.Id = Guid.NewGuid();
            expectedSerial.CreatedDate = DateTime.Now;

            await _expectedSerialRepository.AddAsync(expectedSerial);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _expectedSerialRepository.GetAsync(predicate: x => x.Id == expectedSerial.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedExpectedSerialResponse>(response);
            }
            else
            {
                var response = await _expectedSerialRepository.GetAsync(predicate: x => x.Id == expectedSerial.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedExpectedSerialResponse>(response);
            }
        }
    }
}
