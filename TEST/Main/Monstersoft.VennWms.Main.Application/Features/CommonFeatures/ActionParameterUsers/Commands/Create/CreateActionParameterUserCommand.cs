using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants.ActionParameterUserOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;

public class CreateActionParameterUserCommand : IRequest<CreatedActionParameterUserResponse>
   , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterUsers"];
    public string[] Roles => [Admin, ActionParameterUserOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public CreateActionParameterUserDto ActionParameterUser { get; set; }
    public ActionParameterUserDetailLevel DetailLevel { get; set; }


    public class CreateActionParameterUserCommandHandler : IRequestHandler<CreateActionParameterUserCommand, CreatedActionParameterUserResponse>
    {
        private readonly IActionParameterUserRepository _actionParameterUserRepository;
        private readonly ActionParameterUserBusinessRules _actionParameterUserBusinessRules;
        private readonly IMapper _mapper;

        public CreateActionParameterUserCommandHandler(IActionParameterUserRepository actionParameterUserRepository, IMapper mapper, ActionParameterUserBusinessRules actionParameterUserBusinessRules)
        {
            _actionParameterUserRepository = actionParameterUserRepository;
            _mapper = mapper;
            _actionParameterUserBusinessRules = actionParameterUserBusinessRules;
        }

        public async Task<CreatedActionParameterUserResponse> Handle(CreateActionParameterUserCommand request, CancellationToken cancellationToken)
        {
            _actionParameterUserBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterUser actionParameterUser = _mapper.Map<ActionParameterUser>(request.ActionParameterUser);
            actionParameterUser.CreatedDate = DateTime.Now;

            ActionParameterUser createdRecord = await _actionParameterUserRepository.AddAsync(actionParameterUser);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterUserRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<ActionParameterUser> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);
                    }

                    if (detailLevel.IncludeUser)
                    {
                        query = query.Include(y => y.User);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterUser, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterUserResponse>(response);
            }
            else
            {
                var response = await _actionParameterUserRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterUserResponse>(response);

            }
        }
    }
}
