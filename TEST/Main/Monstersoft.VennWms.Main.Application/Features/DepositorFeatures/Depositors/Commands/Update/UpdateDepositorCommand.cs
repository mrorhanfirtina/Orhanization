using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants.DepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;

public class UpdateDepositorCommand : IRequest<UpdatedDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, DepositorOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetDepositors"];

    public UpdateDepositorDto Depositor { get; set; }
    public DepositorsDetailLevel DetailLevel { get; set; }


    public class UpdateDepositorCommandHandler : IRequestHandler<UpdateDepositorCommand, UpdatedDepositorResponse>
    {
        private readonly IDepositorRepository _depositorRepository;
        private readonly DepositorBusinessRules _depositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateDepositorCommandHandler(IDepositorRepository depositorRepository, DepositorBusinessRules depositorBusinessRules, IMapper mapper)
        {
            _depositorRepository = depositorRepository;
            _depositorBusinessRules = depositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedDepositorResponse> Handle(UpdateDepositorCommand request, CancellationToken cancellationToken)
        {
            _depositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Depositor.Id)
            .CheckCodeExistenceWhenUpdate(request.Depositor.Code, request.Depositor.Id);

            Depositor? currentDepositor = await _depositorRepository.GetAsync(predicate: x => x.Id == request.Depositor.Id,
                include: x => x.Include(y => y.DepositorFeature)
                );

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Depositor? depositor = _mapper.Map(request.Depositor, currentDepositor);
            depositor.UpdatedDate = DateTime.Now;
            depositor.DepositorFeature.UpdatedDate = DateTime.Now;

            await _depositorRepository.UpdateAsync(depositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _depositorRepository.GetAsync(predicate: x => x.Id == depositor.Id,
                include: x =>
                {
                    IQueryable<Depositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeDepositorFeature)
                    {
                        query = query.Include(y => y.DepositorFeature);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);

                        if (detailLevel.CompanyDetailLevel.IncludeAddress)
                        {
                            query = query.Include(y => y.Company).ThenInclude(m => m.Address);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Depositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedDepositorResponse>(response);
            }
            else
            {
                var response = await _depositorRepository.GetAsync(predicate: x => x.Id == depositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedDepositorResponse>(response);

            }
        }
    }
}
