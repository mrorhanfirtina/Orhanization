using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Create;

public class CreateExpectedSerialHierarchyCommand : IRequest<CreatedExpectedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest/*, ISecuredRequest*/
{
    //public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerialHierarchies"];

    public CreateExpectedSerialHierarchyDto ExpectedSerialHierarchy { get; set; }
    public ExpectedSerialHierarchiesDetailLevel DetailLevel { get; set; }

    public class CreateExpectedSerialHierarchyCommandHandler : IRequestHandler<CreateExpectedSerialHierarchyCommand, CreatedExpectedSerialHierarchyResponse>
    {
        private readonly IExpectedSerialHierarchyRepository _expectedSerialHierarchyRepository;
        private readonly ExpectedSerialHierarchyBusinessRules _expectedSerialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public CreateExpectedSerialHierarchyCommandHandler(IExpectedSerialHierarchyRepository expectedSerialHierarchyRepository, IMapper mapper, ExpectedSerialHierarchyBusinessRules expectedSerialHierarchyBusinessRules)
        {
            _expectedSerialHierarchyRepository = expectedSerialHierarchyRepository;
            _mapper = mapper;
            _expectedSerialHierarchyBusinessRules = expectedSerialHierarchyBusinessRules;
        }

        public async Task<CreatedExpectedSerialHierarchyResponse> Handle(CreateExpectedSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialHierarchyBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            ExpectedSerialHierarchy expectedSerialHierarchy = _mapper.Map<ExpectedSerialHierarchy>(request.ExpectedSerialHierarchy);
            expectedSerialHierarchy.Id = Guid.NewGuid();
            expectedSerialHierarchy.CreatedDate = DateTime.Now;

            await _expectedSerialHierarchyRepository.AddAsync(expectedSerialHierarchy);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _expectedSerialHierarchyRepository.GetAsync(predicate: x => x.Id == expectedSerialHierarchy.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedExpectedSerialHierarchyResponse>(response);
            }
            else
            {
                var response = await _expectedSerialHierarchyRepository.GetAsync(predicate: x => x.Id == expectedSerialHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedExpectedSerialHierarchyResponse>(response);
            }
        }
    }
}
