using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants.ReserveReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Create;

public class CreateReserveReasonCommand : IRequest<CreatedReserveReasonResponse>, ITransactionalRequest,
    ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReserveReasons";
    public UserRequestInfo? UserRequestInfo {get; set; }
    public string[] Roles => [Admin, User, Add, Write];

    public CreateReserveReasonDto ReserveReason { get; set; }
    public ReserveReasonsDetailLevel DetailLevel { get; set; }


    public class CreateReserveReasonCommandHandler : IRequestHandler<CreateReserveReasonCommand, CreatedReserveReasonResponse>
    {
        private readonly IReserveReasonRepository _reserveReasonRepository;
        private readonly ReserveReasonBusinessRules _reserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateReserveReasonCommandHandler(IReserveReasonRepository reserveReasonRepository, IMapper mapper, ReserveReasonBusinessRules reserveReasonBusinessRules)
        {
            _reserveReasonRepository = reserveReasonRepository;
            _mapper = mapper;
            _reserveReasonBusinessRules = reserveReasonBusinessRules;
        }

        public async Task<CreatedReserveReasonResponse> Handle(CreateReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _reserveReasonBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ReserveReason.Code);

            ReserveReason reserveReason = _mapper.Map<ReserveReason>(request.ReserveReason);
            reserveReason.Id = Guid.NewGuid();
            reserveReason.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            reserveReason.CreatedDate = DateTime.Now;

            ReserveReason createdRecord = await _reserveReasonRepository.AddAsync(reserveReason);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _reserveReasonRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<ReserveReason> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<ReserveReason, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReserveReasonResponse>(response);
            }
            else
            {
                var response = await _reserveReasonRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReserveReasonResponse>(response);

            }
        }
    }

}


