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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetById;

public class GetByIdReturnAttributeQuery : IRequest<GetByIdReturnAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnAttributesDetailLevel? DetailLevel { get; set; }


    public class GetByIdReturnAttributeQueryHandler : IRequestHandler<GetByIdReturnAttributeQuery, GetByIdReturnAttributeResponse>
    {
        private readonly IReturnAttributeRepository _returnAttributeRepository;
        private readonly ReturnAttributeBusinessRules _returnAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnAttributeQueryHandler(IReturnAttributeRepository returnAttributeRepository, IMapper mapper, ReturnAttributeBusinessRules returnAttributeBusinessRules)
        {
            _returnAttributeRepository = returnAttributeRepository;
            _mapper = mapper;
            _returnAttributeBusinessRules = returnAttributeBusinessRules;
        }

        public async Task<GetByIdReturnAttributeResponse> Handle(GetByIdReturnAttributeQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnAttributeResponse>(await _returnAttributeRepository.GetAsync(x => x.Id == request.Id,
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
                return _mapper.Map<GetByIdReturnAttributeResponse>(await _returnAttributeRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
