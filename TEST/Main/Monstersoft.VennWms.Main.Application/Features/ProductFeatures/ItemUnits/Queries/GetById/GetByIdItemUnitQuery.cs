using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;

public class GetByIdItemUnitQuery : IRequest<GetByIdItemUnitResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ItemUnitDetailLevel DetailLevel { get; set; }


    public class GetByIdItemUnitQueryHandler : IRequestHandler<GetByIdItemUnitQuery, GetByIdItemUnitResponse>
    {
        private readonly IItemUnitRepository _ıtemUnitRepository;
        private readonly ItemUnitBusinessRules _ıtemUnitBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemUnitQueryHandler(IItemUnitRepository ıtemUnitRepository, IMapper mapper, ItemUnitBusinessRules ıtemUnitBusinessRules)
        {
            _ıtemUnitRepository = ıtemUnitRepository;
            _mapper = mapper;
            _ıtemUnitBusinessRules = ıtemUnitBusinessRules;
        }

        public async Task<GetByIdItemUnitResponse> Handle(GetByIdItemUnitQuery request, CancellationToken cancellationToken)
        {
            _ıtemUnitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdItemUnitResponse>(await _ıtemUnitRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ItemUnit> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    if (detailLevel.IncludeUnit)
                    {
                        query = query.Include(y => y.Unit);
                    }

                    if (detailLevel.IncludeItemPackType)
                    {
                        query = query.Include(y => y.ItemPackTypes);

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeLenghtUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.LenghtUnit);
                        }

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeVolumeUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.VolumeUnit);
                        }

                        if (detailLevel.ItemPackTypeDetailLevel.IncludeWeightUnit)
                        {
                            query = query.Include(y => y.ItemPackTypes).ThenInclude(y => y.WeightUnit);
                        }
                    }

                    if (detailLevel.IncludeItemUnitConversion)
                    {
                        query = query.Include(y => y.ItemUnitConversions);

                        if (detailLevel.ItemUnitConversionDetailLevel.IncludeConvertedItemUnit)
                        {
                            query = query.Include(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit);

                            if (detailLevel.ItemUnitConversionDetailLevel.ConvertedItemUnitDetailLevel.IncludeUnit)
                            {
                                query = query.Include(y => y.ItemUnitConversions).ThenInclude(y => y.ConvertedItemUnit).ThenInclude(y => y.Unit);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ItemUnit, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: true, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdItemUnitResponse>(await _ıtemUnitRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: true, cancellationToken: cancellationToken));
            }
        }
    }

}
