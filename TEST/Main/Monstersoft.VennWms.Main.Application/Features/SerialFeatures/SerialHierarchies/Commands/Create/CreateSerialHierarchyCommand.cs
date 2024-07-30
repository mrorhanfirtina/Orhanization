using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Create;

public class CreateSerialHierarchyCommand : IRequest<CreatedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest/*, ISecuredRequest*/
{
    //public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerialHierarchies"];

    public CreateSerialHierarchyDto SerialHierarchy { get; set; }
    public SerialHierarchiesDetailLevel DetailLevel { get; set; }

    public class CreateSerialHierarchyCommandHandler : IRequestHandler<CreateSerialHierarchyCommand, CreatedSerialHierarchyResponse>
    {
        private readonly ISerialHierarchyRepository _serialHierarchyRepository;
        private readonly SerialHierarchyBusinessRules _serialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public CreateSerialHierarchyCommandHandler(ISerialHierarchyRepository serialHierarchyRepository, IMapper mapper, SerialHierarchyBusinessRules serialHierarchyBusinessRules)
        {
            _serialHierarchyRepository = serialHierarchyRepository;
            _mapper = mapper;
            _serialHierarchyBusinessRules = serialHierarchyBusinessRules;
        }

        public async Task<CreatedSerialHierarchyResponse> Handle(CreateSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _serialHierarchyBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            SerialHierarchy serialHierarchy = _mapper.Map<SerialHierarchy>(request.SerialHierarchy);
            serialHierarchy.Id = Guid.NewGuid();
            serialHierarchy.CreatedDate = DateTime.Now;

            await _serialHierarchyRepository.AddAsync(serialHierarchy);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _serialHierarchyRepository.GetAsync(predicate: x => x.Id == serialHierarchy.Id,
                include: x =>
                {
                    IQueryable<SerialHierarchy> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeRootSerial)
                    {
                        query = query.Include(x => x.RootSerial);
                    }

                    if (detailLevel.IncludeChildSerial)
                    {
                        query = query.Include(x => x.ChildSerial);
                    }

                    var includableQuery = query as IIncludableQueryable<SerialHierarchy, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSerialHierarchyResponse>(response);
            }
            else
            {
                var response = await _serialHierarchyRepository.GetAsync(predicate: x => x.Id == serialHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSerialHierarchyResponse>(response);
            }
        }
    }
}
