using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants.UnitConversionOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Update;

public class UpdateUnitConversionCommand : IRequest<UpdatedUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, UnitConversionOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUnitConversions";

    public UpdateUnitConversionDto UnitConversion { get; set; }
    public UnitConversionDetailLevel DetailLevel { get; set; }

    public class UpdateUnitConversionCommandHandler : IRequestHandler<UpdateUnitConversionCommand, UpdatedUnitConversionResponse>
    {
        private readonly IUnitConversionRepository _unitConversionRepository;
        private readonly UnitConversionBusinessRules _unitConversionBusinessRules;
        private readonly IMapper _mapper;

        public UpdateUnitConversionCommandHandler(IUnitConversionRepository unitConversionRepository, UnitConversionBusinessRules unitConversionBusinessRules, IMapper mapper)
        {
            _unitConversionRepository = unitConversionRepository;
            _unitConversionBusinessRules = unitConversionBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedUnitConversionResponse> Handle(UpdateUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _unitConversionBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            UnitConversion? currentUnitConversion = await _unitConversionRepository.GetAsync(predicate: x => x.Id == request.UnitConversion.Id);

            UnitConversion? unitConversion = _mapper.Map(request.UnitConversion, currentUnitConversion);
            unitConversion.UpdatedDate = DateTime.Now;

            await _unitConversionRepository.UpdateAsync(unitConversion);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _unitConversionRepository.GetAsync(predicate: x => x.Id == unitConversion.Id,
                include: x =>
                {
                    IQueryable<UnitConversion> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReferenceUnit)
                    {
                        query = query.Include(y => y.ReferenceUnit);
                    }

                    if (detailLevel.IncludeTargetUnit)
                    {
                        query = query.Include(y => y.TargetUnit);
                    }

                    var includableQuery = query as IIncludableQueryable<UnitConversion, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnitConversionResponse>(response);
            }
            else
            {
                var response = await _unitConversionRepository.GetAsync(predicate: x => x.Id == unitConversion.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedUnitConversionResponse>(response);

            }
        }
    }
}
