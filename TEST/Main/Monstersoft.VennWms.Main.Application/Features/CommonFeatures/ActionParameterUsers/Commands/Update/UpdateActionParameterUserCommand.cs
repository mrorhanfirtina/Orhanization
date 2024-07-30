using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants.ActionParameterUserOperationClaims;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Statics;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Update;

public class UpdateActionParameterUserCommand : IRequest<UpdatedActionParameterUserResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterUsers"];
    public string[] Roles => [Admin, ActionParameterUserOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateActionParameterUserDto ActionParameterUser { get; set; }
    public ActionParameterUserDetailLevel DetailLevel { get; set; }


    public class UpdateActionParameterUserCommandHandler : IRequestHandler<UpdateActionParameterUserCommand, UpdatedActionParameterUserResponse>
    {
        private readonly IActionParameterUserRepository _actionParameterUserRepository;
        private readonly ActionParameterUserBusinessRules _actionParameterUserBusinessRules;
        private readonly IMapper _mapper;

        public UpdateActionParameterUserCommandHandler(IActionParameterUserRepository actionParameterUserRepository, ActionParameterUserBusinessRules actionParameterUserBusinessRules, IMapper mapper)
        {
            _actionParameterUserRepository = actionParameterUserRepository;
            _actionParameterUserBusinessRules = actionParameterUserBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedActionParameterUserResponse> Handle(UpdateActionParameterUserCommand request, CancellationToken cancellationToken)
        {
            _actionParameterUserBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ActionParameterUser.Id);

            ActionParameterUser? currentActionParameterUser = await _actionParameterUserRepository.GetAsync(
            predicate: x => x.Id == request.ActionParameterUser.Id,
            cancellationToken: cancellationToken,
            withDeleted: false, enableTracking: true);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ActionParameterUser? actionParameterUser = _mapper.Map(request.ActionParameterUser, currentActionParameterUser);
            actionParameterUser.UpdatedDate = DateTime.Now;

            await _actionParameterUserRepository.UpdateAsync(actionParameterUser);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterUserRepository.GetAsync(predicate: x => x.Id == actionParameterUser.Id,
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

                return _mapper.Map<UpdatedActionParameterUserResponse>(response);
            }
            else
            {
                var response = await _actionParameterUserRepository.GetAsync(predicate: x => x.Id == actionParameterUser.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterUserResponse>(response);

            }
        }
    }
}
