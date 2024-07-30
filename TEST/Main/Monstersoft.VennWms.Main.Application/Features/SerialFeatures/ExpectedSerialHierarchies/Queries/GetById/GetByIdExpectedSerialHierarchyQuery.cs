using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetById;

public class GetByIdExpectedSerialHierarchyQuery : IRequest<GetByIdExpectedSerialHierarchyResponse>, ITransactionalRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    //public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public ExpectedSerialHierarchiesDetailLevel DetailLevel { get; set; }



    public class GetByIdExpectedSerialHierarchyQueryHandler : IRequestHandler<GetByIdExpectedSerialHierarchyQuery, GetByIdExpectedSerialHierarchyResponse>
    {
        private readonly IExpectedSerialHierarchyRepository _expectedSerialHierarchyRepository;
        private readonly ExpectedSerialHierarchyBusinessRules _expectedSerialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdExpectedSerialHierarchyQueryHandler(IExpectedSerialHierarchyRepository expectedSerialHierarchyRepository, IMapper mapper, ExpectedSerialHierarchyBusinessRules expectedSerialHierarchyBusinessRules)
        {
            _expectedSerialHierarchyRepository = expectedSerialHierarchyRepository;
            _mapper = mapper;
            _expectedSerialHierarchyBusinessRules = expectedSerialHierarchyBusinessRules;
        }

        public async Task<GetByIdExpectedSerialHierarchyResponse> Handle(GetByIdExpectedSerialHierarchyQuery request, CancellationToken cancellationToken)
        {
            _expectedSerialHierarchyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdExpectedSerialHierarchyResponse>(await _expectedSerialHierarchyRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ExpectedSerialHierarchy> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeRootSerial)
                    {
                        query = query.Include(x => x.RootSerial);
                    }

                    if (detailLevel.IncludeChildSerial)
                    {
                        query = query.Include(x => x.ChildSerial);
                    }

                    var includableQuery = query as IIncludableQueryable<ExpectedSerialHierarchy, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdExpectedSerialHierarchyResponse>(await _expectedSerialHierarchyRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
