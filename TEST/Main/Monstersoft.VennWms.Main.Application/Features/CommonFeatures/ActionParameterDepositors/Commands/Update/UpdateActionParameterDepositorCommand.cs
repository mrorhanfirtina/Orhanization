using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants.ActionParameterDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Update;

public class UpdateActionParameterDepositorCommand : IRequest<UpdatedActionParameterDepositorResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDepositors"];
    public string[] Roles => [Admin, ActionParameterDepositorOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateActionParameterDepositorDto ActionParameterDepositor { get; set; }
    public ActionParameterDepositorDetailLevel DetailLevel { get; set; }


    public class UpdateActionParameterDepositorCommandHandler : IRequestHandler<UpdateActionParameterDepositorCommand, UpdatedActionParameterDepositorResponse>
    {
        private readonly IActionParameterDepositorRepository _actionParameterDepositorRepository;
        private readonly ActionParameterDepositorBusinessRules _actionParameterDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateActionParameterDepositorCommandHandler(IActionParameterDepositorRepository actionParameterDepositorRepository, ActionParameterDepositorBusinessRules actionParameterDepositorBusinessRules, IMapper mapper)
        {
            _actionParameterDepositorRepository = actionParameterDepositorRepository;
            _actionParameterDepositorBusinessRules = actionParameterDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedActionParameterDepositorResponse> Handle(UpdateActionParameterDepositorCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ActionParameterDepositor.Id);

            ActionParameterDepositor? currentActionParameterDepositor = await _actionParameterDepositorRepository.GetAsync(
            predicate: x => x.Id == request.ActionParameterDepositor.Id,
            cancellationToken: cancellationToken,
            withDeleted: false, enableTracking: true);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ActionParameterDepositor? actionParameterDepositor = _mapper.Map(request.ActionParameterDepositor, currentActionParameterDepositor);
            actionParameterDepositor.UpdatedDate = DateTime.Now;

            await _actionParameterDepositorRepository.UpdateAsync(actionParameterDepositor);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterDepositorRepository.GetAsync(predicate: x => x.Id == actionParameterDepositor.Id,
                include: x =>
                {
                    IQueryable<ActionParameterDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);

                        if (detailLevel.ActionParameterDepositorParameterDetailLevel.IncludeCategory)
                        {
                            query = query.Include(y => y.ActionParameter).ThenInclude(v => v.ActionParameterCategory);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        if (detailLevel.ActionParameterDepositorDepositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(v => v.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterDepositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterDepositorResponse>(response);
            }
            else
            {
                var response = await _actionParameterDepositorRepository.GetAsync(predicate: x => x.Id == actionParameterDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterDepositorResponse>(response);

            }
        }
    }
}
