using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetById;

public class GetByIdReturnAttributeValueQuery : IRequest<GetByIdReturnAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class GetByIdReturnAttributeValueQueryHandler : IRequestHandler<GetByIdReturnAttributeValueQuery, GetByIdReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnAttributeValueQueryHandler(IReturnAttributeValueRepository returnAttributeValueRepository, IMapper mapper, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _mapper = mapper;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
        }

        public async Task<GetByIdReturnAttributeValueResponse> Handle(GetByIdReturnAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnAttributeValueResponse>(await _returnAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ReturnAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeReturnAttribute)
                    {
                        query = query.Include(y => y.ReturnAttribute);

                        var returnAttributeDetailLevel = detailLevel.ReturnAttributeDetailLevel;

                        if (returnAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ReturnAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnAttributeValue, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnAttributeValueResponse>(await _returnAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

