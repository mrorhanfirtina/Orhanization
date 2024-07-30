using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Update;

public class UpdateUnsuitReasonCommand : IRequest<UpdatedUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnsuitReasons"];
    public string[] Roles => [Admin, User, Write, UnsuitReasonOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateUnsuitReasonDto UnsuitReason { get; set; }
    public UnsuitReasonsDetailLevel DetailLevel { get; set; }


    public class UpdateUnsuitReasonCommandHandler : IRequestHandler<UpdateUnsuitReasonCommand, UpdatedUnsuitReasonResponse>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateUnsuitReasonCommandHandler(IUnsuitReasonRepository unsuitReasonRepository, UnsuitReasonBusinessRules unsuitReasonBusinessRules, IMapper mapper)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedUnsuitReasonResponse> Handle(UpdateUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.UnsuitReason.Id)
            .CheckCodeExistenceWhenUpdate(request.UnsuitReason.Code, request.UnsuitReason.Id);

            UnsuitReason? currentUnsuitReason = await _unsuitReasonRepository.GetAsync(predicate: x => x.Id == request.UnsuitReason.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            UnsuitReason? unsuitReason = _mapper.Map(request.UnsuitReason, currentUnsuitReason);
            unsuitReason.UpdatedDate = DateTime.Now;

            await _unsuitReasonRepository.UpdateAsync(unsuitReason);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _unsuitReasonRepository.GetAsync(predicate: x => x.Id == unsuitReason.Id,
                include: x =>
                {
                    IQueryable<UnsuitReason> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<UnsuitReason, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnsuitReasonResponse>(response);
            }
            else
            {
                var response = await _unsuitReasonRepository.GetAsync(predicate: x => x.Id == unsuitReason.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnsuitReasonResponse>(response);

            }
        }
    }
}
