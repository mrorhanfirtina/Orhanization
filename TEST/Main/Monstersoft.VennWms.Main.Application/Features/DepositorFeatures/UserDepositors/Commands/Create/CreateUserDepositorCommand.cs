using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants.UserDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;

public class CreateUserDepositorCommand : IRequest<CreatedUserDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUserDepositors";

    public CreateUserDepositorDto UserDepositor { get; set; }
    public UserDepositorDetailLevel DetailLevel { get; set; }


    public class CreateUserDepositorCommandHandler : IRequestHandler<CreateUserDepositorCommand, CreatedUserDepositorResponse>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateUserDepositorCommandHandler(IUserDepositorRepository userDepositorRepository, IMapper mapper, UserDepositorBusinessRules userDepositorBusinessRules)
        {
            _userDepositorRepository = userDepositorRepository;
            _mapper = mapper;
            _userDepositorBusinessRules = userDepositorBusinessRules;
        }

        public async Task<CreatedUserDepositorResponse> Handle(CreateUserDepositorCommand request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckUserIdExistence(request.UserDepositor.UserId)
                .CheckDepositorIdExistence(request.UserDepositor.DepositorId);


            UserDepositor userDepositor = _mapper.Map<UserDepositor>(request.UserDepositor);
            userDepositor.Id = Guid.NewGuid();
            userDepositor.CreatedDate = DateTime.Now;

            await _userDepositorRepository.AddAsync(userDepositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _userDepositorRepository.GetAsync(predicate: x => x.Id == userDepositor.Id,
                include: x =>
                {
                    IQueryable<UserDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeUser)
                    {
                        query = query.Include(y => y.User);
                    }

                    var includableQuery = query as IIncludableQueryable<UserDepositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedUserDepositorResponse>(response);
            }
            else
            {
                var response = await _userDepositorRepository.GetAsync(predicate: x => x.Id == userDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedUserDepositorResponse>(response);
            }
        }
    }

}

