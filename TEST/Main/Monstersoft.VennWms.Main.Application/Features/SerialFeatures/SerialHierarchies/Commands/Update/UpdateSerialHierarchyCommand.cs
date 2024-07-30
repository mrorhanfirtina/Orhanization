using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Commands.Update;

public class UpdateSerialHierarchyCommand : IRequest<UpdatedSerialHierarchyResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    //public string[] Roles => [Admin, User, SerialHierarchyOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSerialHierarchies"];

    public UpdateSerialHierarchyDto SerialHierarchy { get; set; }
    public SerialHierarchiesDetailLevel DetailLevel { get; set; }



    public class UpdateSerialHierarchyCommandHandler : IRequestHandler<UpdateSerialHierarchyCommand, UpdatedSerialHierarchyResponse>
    {
        private readonly ISerialHierarchyRepository _serialHierarchyRepository;
        private readonly SerialHierarchyBusinessRules _serialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSerialHierarchyCommandHandler(ISerialHierarchyRepository serialHierarchyRepository, SerialHierarchyBusinessRules serialHierarchyBusinessRules, IMapper mapper)
        {
            _serialHierarchyRepository = serialHierarchyRepository;
            _serialHierarchyBusinessRules = serialHierarchyBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedSerialHierarchyResponse> Handle(UpdateSerialHierarchyCommand request, CancellationToken cancellationToken)
        {
            _serialHierarchyBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.SerialHierarchy.Id);


            SerialHierarchy? currentSerialHierarchy = await _serialHierarchyRepository.GetAsync(predicate: x => x.Id == request.SerialHierarchy.Id);

            SerialHierarchy? serialHierarchy = _mapper.Map(request.SerialHierarchy, currentSerialHierarchy);
            serialHierarchy.UpdatedDate = DateTime.Now;

            await _serialHierarchyRepository.UpdateAsync(serialHierarchy);

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

                return _mapper.Map<UpdatedSerialHierarchyResponse>(response);
            }
            else
            {
                var response = await _serialHierarchyRepository.GetAsync(predicate: x => x.Id == serialHierarchy.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSerialHierarchyResponse>(response);
            }
        }
    }
}
