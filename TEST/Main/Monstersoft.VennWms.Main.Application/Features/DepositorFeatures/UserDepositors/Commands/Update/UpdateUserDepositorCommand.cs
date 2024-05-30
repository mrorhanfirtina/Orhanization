using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Commands.Update;

public class UpdateUserDepositorCommand : IRequest<UpdatedUserDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, UserDepositorOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUserDepositors";

    public UpdateUserDepositorDto UserDepositor { get; set; }
    public UserDepositorsDetailLevel DetailLevel { get; set; }


    public class UpdateUserDepositorCommandHandler : IRequestHandler<UpdateUserDepositorCommand, UpdatedUserDepositorResponse>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateUserDepositorCommandHandler(IUserDepositorRepository userDepositorRepository, UserDepositorBusinessRules userDepositorBusinessRules, IMapper mapper)
        {
            _userDepositorRepository = userDepositorRepository;
            _userDepositorBusinessRules = userDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedUserDepositorResponse> Handle(UpdateUserDepositorCommand request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.UserDepositor.Id)
            .CheckUserIdExistence(request.UserDepositor.UserId)
            .CheckDepositorIdExistence(request.UserDepositor.DepositorId);

            UserDepositor? currentUserDepositor = await _userDepositorRepository.GetAsync(predicate: x => x.Id == request.UserDepositor.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            UserDepositor? userDepositor = _mapper.Map(request.UserDepositor, currentUserDepositor);
            userDepositor.UpdatedDate = DateTime.Now;

            await _userDepositorRepository.UpdateAsync(userDepositor);

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

                return _mapper.Map<UpdatedUserDepositorResponse>(response);
            }
            else
            {
                var response = await _userDepositorRepository.GetAsync(predicate: x => x.Id == userDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUserDepositorResponse>(response);
            }
        }
    }
}

