using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Commands.Update;

public class UpdateExpectedSerialHierarchyCommand : IRequest<UpdatedExpectedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    //public string[] Roles => [Admin, User, ExpectedSerialHierarchyOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetExpectedSerialHierarchies"];

    public UpdateExpectedSerialHierarchyDto ExpectedSerialHierarchy { get; set; }
    public ExpectedSerialHierarchiesDetailLevel DetailLevel { get; set; }



    public class UpdateExpectedSerialHierarchyCommandHandler : IRequestHandler<UpdateExpectedSerialHierarchyCommand, UpdatedExpectedSerialHierarchyResponse>
    {
        private readonly IExpectedSerialHierarchyRepository _expectedSerialHierarchyRepository;
        private readonly ExpectedSerialHierarchyBusinessRules _expectedSerialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateExpectedSerialHierarchyCommandHandler(IExpectedSerialHierarchyRepository expectedSerialHierarchyRepository, ExpectedSerialHierarchyBusinessRules expectedSerialHierarchyBusinessRules, IMapper mapper)
        {
            _expectedSerialHierarchyRepository = expectedSerialHierarchyRepository;
            _expectedSerialHierarchyBusinessRules = expectedSerialHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedExpectedSerialHierarchyResponse> Handle(UpdateExpectedSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _expectedSerialHierarchyBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ExpectedSerialHierarchy.Id);


            ExpectedSerialHierarchy? currentExpectedSerialHierarchy = await _expectedSerialHierarchyRepository.GetAsync(predicate: x => x.Id == request.ExpectedSerialHierarchy.Id);

            ExpectedSerialHierarchy? expectedSerialHierarchy = _mapper.Map(request.ExpectedSerialHierarchy, currentExpectedSerialHierarchy);
            expectedSerialHierarchy.UpdatedDate = DateTime.Now;

            await _expectedSerialHierarchyRepository.UpdateAsync(expectedSerialHierarchy);

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

                return _mapper.Map<UpdatedExpectedSerialHierarchyResponse>(response);
            }
            else
            {
                var response = await _expectedSerialHierarchyRepository.GetAsync(predicate: x => x.Id == expectedSerialHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedExpectedSerialHierarchyResponse>(response);
            }
        }
    }
}
