using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants.ActionParameterDefaultOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Commands.Create;

public class CreateActionParameterDefaultCommand : IRequest<CreatedActionParameterDefaultResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDefaults"];

    public CreateActionParameterDefaultDto ActionParameterDefault { get; set; }
    public ActionParameterDefaultsDetailLevel DetailLevel { get; set; }

    public class CreateActionParameterDefaultCommandHandler : IRequestHandler<CreateActionParameterDefaultCommand, CreatedActionParameterDefaultResponse>
    {
        private readonly IActionParameterDefaultRepository _actionParameterDefaultRepository;
        private readonly ActionParameterDefaultBusinessRules _actionParameterDefaultBusinessRules;
        private readonly IMapper _mapper;

        public CreateActionParameterDefaultCommandHandler(IActionParameterDefaultRepository actionParameterDefaultRepository, IMapper mapper, ActionParameterDefaultBusinessRules actionParameterDefaultBusinessRules)
        {
            _actionParameterDefaultRepository = actionParameterDefaultRepository;
            _mapper = mapper;
            _actionParameterDefaultBusinessRules = actionParameterDefaultBusinessRules;
        }

        public async Task<CreatedActionParameterDefaultResponse> Handle(CreateActionParameterDefaultCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDefaultBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);


            ActionParameterDefault actionParameterDefault = _mapper.Map<ActionParameterDefault>(request.ActionParameterDefault);
            actionParameterDefault.Id = Guid.NewGuid();
            actionParameterDefault.CreatedDate = DateTime.Now;

            await _actionParameterDefaultRepository.AddAsync(actionParameterDefault);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == actionParameterDefault.Id,
                include: x =>
                {
                    IQueryable<ActionParameterDefault> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(x => x.ActionParameter);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterDefault, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterDefaultResponse>(response);
            }
            else
            {
                var response = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == actionParameterDefault.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterDefaultResponse>(response);
            }
        }
    }
}
