using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Update;

public class UpdateExpectedSerialCommand : IRequest<UpdatedExpectedSerialResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ExpectedSerialOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerials"];

    public UpdateExpectedSerialDto ExpectedSerial { get; set; }
    public ExpectedSerialsDetailLevel DetailLevel { get; set; }



    public class UpdateExpectedSerialCommandHandler : IRequestHandler<UpdateExpectedSerialCommand, UpdatedExpectedSerialResponse>
    {
        private readonly IExpectedSerialRepository _expectedSerialRepository;
        private readonly ExpectedSerialBusinessRules _expectedSerialBusinessRules;
        private readonly IMapper _mapper;

        public UpdateExpectedSerialCommandHandler(IExpectedSerialRepository expectedSerialRepository, ExpectedSerialBusinessRules expectedSerialBusinessRules, IMapper mapper)
        {
            _expectedSerialRepository = expectedSerialRepository;
            _expectedSerialBusinessRules = expectedSerialBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedExpectedSerialResponse> Handle(UpdateExpectedSerialCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ExpectedSerial.Id);


            ExpectedSerial? currentExpectedSerial = await _expectedSerialRepository.GetAsync(predicate: x => x.Id == request.ExpectedSerial.Id);

            ExpectedSerial? expectedSerial = _mapper.Map(request.ExpectedSerial, currentExpectedSerial);
            expectedSerial.UpdatedDate = DateTime.Now;

            await _expectedSerialRepository.UpdateAsync(expectedSerial);

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

                return _mapper.Map<UpdatedExpectedSerialResponse>(response);
            }
            else
            {
                var response = await _expectedSerialRepository.GetAsync(predicate: x => x.Id == expectedSerial.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedExpectedSerialResponse>(response);
            }
        }
    }
}
