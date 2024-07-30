using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.CreateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Create;

public class CreateUnitConversionCommand : IRequest<CreatedUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetUnitConversions"];

    public CreateUnitConversionDto UnitConversion { get; set; }
    public UnitConversionsDetailLevel DetailLevel { get; set; }


    public class CreateUnitConversionCommandHandler : IRequestHandler<CreateUnitConversionCommand, CreatedUnitConversionResponse>
    {
        private readonly IUnitConversionRepository _unitConversionRepository;
        private readonly UnitConversionBusinessRules _unitConversionBusinessRules;
        private readonly IMapper _mapper;

        public CreateUnitConversionCommandHandler(IUnitConversionRepository unitConversionRepository, IMapper mapper, UnitConversionBusinessRules unitConversionBusinessRules)
        {
            _unitConversionRepository = unitConversionRepository;
            _mapper = mapper;
            _unitConversionBusinessRules = unitConversionBusinessRules;
        }

        public async Task<CreatedUnitConversionResponse> Handle(CreateUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _unitConversionBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            UnitConversion unitConversion = _mapper.Map<UnitConversion>(request.UnitConversion);
            unitConversion.CreatedDate = DateTime.Now;

            UnitConversion createdRecord = await _unitConversionRepository.AddAsync(unitConversion);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _unitConversionRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
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

                return _mapper.Map<CreatedUnitConversionResponse>(response);
            }
            else
            {
                var response = await _unitConversionRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedUnitConversionResponse>(response);

            }
        }
    }
}
