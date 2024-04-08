using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants.SiteDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;

public class UpdateSiteDepositorCommand : IRequest<UpdatedSiteDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, SiteDepositorOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSiteDepositors";

    public UpdateSiteDepositorDto SiteDepositor { get; set; }


    public class UpdateSiteDepositorCommandHandler : IRequestHandler<UpdateSiteDepositorCommand, UpdatedSiteDepositorResponse>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSiteDepositorCommandHandler(ISiteDepositorRepository siteDepositorRepository, SiteDepositorBusinessRules siteDepositorBusinessRules, IMapper mapper)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedSiteDepositorResponse> Handle(UpdateSiteDepositorCommand request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.SiteDepositor.Id)
            .CheckSiteIdExistence(request.SiteDepositor.SiteId)
            .CheckDepositorIdExistence(request.SiteDepositor.DepositorId);

            SiteDepositor? currentSiteDepositor = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == request.SiteDepositor.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            SiteDepositor? siteDepositor = _mapper.Map(request.SiteDepositor, currentSiteDepositor);
            siteDepositor.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedSiteDepositorResponse>(await _siteDepositorRepository.UpdateAsync(siteDepositor));
        }
    }
}

