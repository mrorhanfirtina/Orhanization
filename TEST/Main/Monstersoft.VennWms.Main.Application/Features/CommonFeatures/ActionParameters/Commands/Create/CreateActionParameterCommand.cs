using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants.ActionParameterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Create;

public class CreateActionParameterCommand : IRequest<CreatedActionParameterResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameters"];
    public string[] Roles => [Admin, ActionParameterOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public CreateActionParameterDto ActionParameter { get; set; }
    public ActionParameterDetailLevel DetailLevel { get; set; }


    public class CreateActionParameterCommandHandler : IRequestHandler<CreateActionParameterCommand, CreatedActionParameterResponse>
    {
        private readonly IActionParameterRepository _actionParameterRepository;
        private readonly ActionParameterBusinessRules _actionParameterBusinessRules;
        private readonly IMapper _mapper;

        public CreateActionParameterCommandHandler(IActionParameterRepository actionParameterRepository, IMapper mapper, ActionParameterBusinessRules actionParameterBusinessRules)
        {
            _actionParameterRepository = actionParameterRepository;
            _mapper = mapper;
            _actionParameterBusinessRules = actionParameterBusinessRules;
        }

        public async Task<CreatedActionParameterResponse> Handle(CreateActionParameterCommand request, CancellationToken cancellationToken)
        {
            _actionParameterBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameter actionParameter = _mapper.Map<ActionParameter>(request.ActionParameter);
            actionParameter.CreatedDate = DateTime.Now;

            ActionParameter createdRecord = await _actionParameterRepository.AddAsync(actionParameter);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<ActionParameter> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameterUser)
                    {
                        query = query.Include(y => y.ActionParameterUsers);

                        if (detailLevel.ActionParameterUserDetailLevel.IncludeUser)
                        {
                            query = query.Include(y => y.ActionParameterUsers).ThenInclude(v => v.User);
                        }
                    }

                    if (detailLevel.IncludeActionParameterCategory)
                    {
                        query = query.Include(y => y.ActionParameterCategory);
                    }

                    if (detailLevel.IncludeActionParameterDepositor)
                    {
                        query = query.Include(y => y.ActionParameterDepositors);

                        if (detailLevel.ActionParameterDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor);

                            if (detailLevel.ActionParameterDepositorDetailLevel.ActionParameterCompanyDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor).ThenInclude(v => v.Company);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameter, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterResponse>(response);
            }
            else
            {
                var response = await _actionParameterRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterResponse>(response);

            }
        }
    }
}
