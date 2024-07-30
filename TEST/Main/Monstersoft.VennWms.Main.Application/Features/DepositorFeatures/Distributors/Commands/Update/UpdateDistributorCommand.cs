using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;

public class UpdateDistributorCommand : IRequest<UpdatedDistributorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, DistributorOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetDisturbitors"];

    public UpdateDistributorDto Disturbitor { get; set; }
    public DistributorsDetailLevel DetailLevel { get; set; }


    public class UpdateDisturbitorCommandHandler : IRequestHandler<UpdateDistributorCommand, UpdatedDistributorResponse>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateDisturbitorCommandHandler(IDistributorRepository disturbitorRepository, DistributorBusinessRules disturbitorBusinessRules, IMapper mapper)
        {
            _disturbitorRepository = disturbitorRepository;
            _disturbitorBusinessRules = disturbitorBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedDistributorResponse> Handle(UpdateDistributorCommand request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckIdExistence(request.Disturbitor.Id)
                .CheckCodeExistenceWhenUpdate(request.Disturbitor.Code, request.Disturbitor.Id);

            Distributor? currentDisturbitor = await _disturbitorRepository.GetAsync(predicate: x => x.Id == request.Disturbitor.Id && !x.DeletedDate.HasValue, 
                include: x => x.Include(y => y.Address));

            Distributor? disturbitor = _mapper.Map(request.Disturbitor, currentDisturbitor);
            disturbitor.UpdatedDate = DateTime.Now;
            disturbitor.Address.UpdatedDate = DateTime.Now;

            await _disturbitorRepository.UpdateAsync(disturbitor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _disturbitorRepository.GetAsync(predicate: x => x.Id == disturbitor.Id,
                include: x =>
                {
                    IQueryable<Distributor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeBranch)
                    {
                        query = query.Include(y => y.Branches);
                    }


                    var includableQuery = query as IIncludableQueryable<Distributor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedDistributorResponse>(response);
            }
            else
            {
                var response = await _disturbitorRepository.GetAsync(predicate: x => x.Id == disturbitor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedDistributorResponse>(response);

            }
        }
    }
}

