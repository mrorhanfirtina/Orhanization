using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants.ReturnAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetByCode;

public class GetByCodeReturnAttributeQuery : IRequest<GetByCodeReturnAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public ReturnAttributesDetailLevel? DetailLevel { get; set; }


    public class GetByCodeReturnAttributeQueryHandler : IRequestHandler<GetByCodeReturnAttributeQuery, GetByCodeReturnAttributeResponse>
    {
        private readonly IReturnAttributeRepository _returnAttributeRepository;
        private readonly ReturnAttributeBusinessRules _returnAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReturnAttributeQueryHandler(IReturnAttributeRepository returnAttributeRepository, IMapper mapper, ReturnAttributeBusinessRules returnAttributeBusinessRules)
        {
            _returnAttributeRepository = returnAttributeRepository;
            _mapper = mapper;
            _returnAttributeBusinessRules = returnAttributeBusinessRules;
        }

        public async Task<GetByCodeReturnAttributeResponse> Handle(GetByCodeReturnAttributeQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodeReturnAttributeResponse>(await _returnAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                include: x =>
                {
                    IQueryable<ReturnAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnAttribute, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByCodeReturnAttributeResponse>(await _returnAttributeRepository.GetAsync(
                predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
