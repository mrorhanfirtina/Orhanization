using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
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
    public string? CacheGroupKey => "GetDepositors";

    public UpdateDepositorDto Depositor { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedDepositorResponse>(await _depositorRepository.UpdateAsync(depositor));
        }
    }
}
