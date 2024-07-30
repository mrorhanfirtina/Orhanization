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
using static Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants.ExpectedSerialOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetById;

public class GetByIdExpectedSerialQuery : IRequest<GetByIdExpectedSerialResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public ExpectedSerialsDetailLevel DetailLevel { get; set; }



    public class GetByIdExpectedSerialQueryHandler : IRequestHandler<GetByIdExpectedSerialQuery, GetByIdExpectedSerialResponse>
    {
        private readonly IExpectedSerialRepository _expectedSerialRepository;
        private readonly ExpectedSerialBusinessRules _expectedSerialBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdExpectedSerialQueryHandler(IExpectedSerialRepository expectedSerialRepository, IMapper mapper, ExpectedSerialBusinessRules expectedSerialBusinessRules)
        {
            _expectedSerialRepository = expectedSerialRepository;
            _mapper = mapper;
            _expectedSerialBusinessRules = expectedSerialBusinessRules;
        }

        public async Task<GetByIdExpectedSerialResponse> Handle(GetByIdExpectedSerialQuery request, CancellationToken cancellationToken)
        {
            _expectedSerialBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdExpectedSerialResponse>(await _expectedSerialRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdExpectedSerialResponse>(await _expectedSerialRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
