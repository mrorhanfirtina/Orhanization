using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants.LockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetByCode;

public class GetByCodeLockReasonQuery : IRequest<GetByCodeLockReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string Code { get; set; }
    public LockReasonsDetailLevel DetailLevel { get; set; }


    public class GetByCodeLockReasonQueryHandler : IRequestHandler<GetByCodeLockReasonQuery, GetByCodeLockReasonResponse>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeLockReasonQueryHandler(ILockReasonRepository lockReasonRepository, IMapper mapper, LockReasonBusinessRules lockReasonBusinessRules)
    {
            _lockReasonRepository = lockReasonRepository;
            _mapper = mapper;
            _lockReasonBusinessRules = lockReasonBusinessRules;
        }

        public async Task<GetByCodeLockReasonResponse> Handle(GetByCodeLockReasonQuery request, CancellationToken cancellationToken)
    {
            _lockReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeLockReasonResponse>(await _lockReasonRepository.GetAsync(
                    include: x =>
                    {
                        IQueryable<LockReason> query = x;

                        var detailLevel = request.DetailLevel;

                        if (detailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.DepositorCompany);
                        }


                        var includableQuery = query as IIncludableQueryable<LockReason, object>;
                        return includableQuery;
                    },
                    predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                    enableTracking: true, withDeleted: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeLockReasonResponse>(await _lockReasonRepository.GetAsync(
                    predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                    enableTracking: true, withDeleted: false, cancellationToken: cancellationToken));
            }
        }
    }
}

