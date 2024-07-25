using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.SerialRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetById;

public class GetByIdSerialHierarchyQuery : IRequest<GetByIdSerialHierarchyResponse>, ITransactionalRequest, ILoggableRequest/*, ISecuredRequest*/, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    //public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public SerialHierarchiesDetailLevel DetailLevel { get; set; }



    public class GetByIdSerialHierarchyQueryHandler : IRequestHandler<GetByIdSerialHierarchyQuery, GetByIdSerialHierarchyResponse>
    {
        private readonly ISerialHierarchyRepository _serialHierarchyRepository;
        private readonly SerialHierarchyBusinessRules _serialHierarchyBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSerialHierarchyQueryHandler(ISerialHierarchyRepository serialHierarchyRepository, IMapper mapper, SerialHierarchyBusinessRules serialHierarchyBusinessRules)
        {
            _serialHierarchyRepository = serialHierarchyRepository;
            _mapper = mapper;
            _serialHierarchyBusinessRules = serialHierarchyBusinessRules;
        }

        public async Task<GetByIdSerialHierarchyResponse> Handle(GetByIdSerialHierarchyQuery request, CancellationToken cancellationToken)
        {
            _serialHierarchyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdSerialHierarchyResponse>(await _serialHierarchyRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdSerialHierarchyResponse>(await _serialHierarchyRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
