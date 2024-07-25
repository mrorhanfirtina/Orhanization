using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;

public class UpdateUnitCommand : IRequest<UpdatedUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnits"];
    public string[] Roles => [Admin, User, Write, UnitOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateUnitDto Unit { get; set; }
    public UnitsDetailLevel DetailLevel { get; set; }


    public class UpdateUnitCommandHandler : IRequestHandler<UpdateUnitCommand, UpdatedUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public UpdateUnitCommandHandler(IUnitRepository unitRepository, UnitBusinessRules unitBusinessRules, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _unitBusinessRules = unitBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedUnitResponse> Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Unit.Id)
            .CheckCodeExistenceWhenUpdate(request.Unit.Code, request.Unit.Id);

            Unit? currentUnit = await _unitRepository.GetAsync(predicate: x => x.Id == request.Unit.Id,
                include: x => x.Include(y => y.ReferenceUnitConversions),
                cancellationToken: cancellationToken,
                withDeleted: false,
                enableTracking: true
                );

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Unit? unit = _mapper.Map(request.Unit, currentUnit);
            unit.UpdatedDate = DateTime.Now;

            unit.ReferenceUnitConversions.ToList().ForEach(x =>
            {
                x.CreatedDate = unit.CreatedDate;
                x.UpdatedDate = DateTime.Now;
            });

            await _unitRepository.UpdateAsync(unit);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _unitRepository.GetAsync(predicate: x => x.Id == unit.Id,
                include: x =>
                {
                    IQueryable<Unit> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeReferenceUnit)
                    {
                        query = query.Include(y => y.ReferenceUnitConversions);

                        if (detailLevel.ReferenceUnitDetailLevel.IncludeTargetUnit)
                        {
                            query = query.Include(y => y.ReferenceUnitConversions).ThenInclude(z => z.TargetUnit);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Unit, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnitResponse>(response);
            }
            else
            {
                var response = await _unitRepository.GetAsync(predicate: x => x.Id == unit.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnitResponse>(response);
            }
        }
    }
}
