using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetById;

public class GetByIdItemPackTypeQuery : IRequest<GetByIdItemPackTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ItemPackTypesDetailLevel DetailLevel { get; set; }


    public class GetByIdItemPackTypeQueryHandler : IRequestHandler<GetByIdItemPackTypeQuery, GetByIdItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _ıtemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _ıtemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemPackTypeQueryHandler(IItemPackTypeRepository ıtemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules ıtemPackTypeBusinessRules)
        {
            _ıtemPackTypeRepository = ıtemPackTypeRepository;
            _mapper = mapper;
            _ıtemPackTypeBusinessRules = ıtemPackTypeBusinessRules;
        }

        public async Task<GetByIdItemPackTypeResponse> Handle(GetByIdItemPackTypeQuery request, CancellationToken cancellationToken)
        {
            _ıtemPackTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdItemPackTypeResponse>(await _ıtemPackTypeRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ItemPackType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeLenghtUnit)
                    {
                        query = query.Include(y => y.LenghtUnit);
                    }

                    if (detailLevel.IncludeVolumeUnit)
                    {
                        query = query.Include(y => y.VolumeUnit);
                    }

                    if (detailLevel.IncludeWeightUnit)
                    {
                        query = query.Include(y => y.WeightUnit);
                    }

                    if (detailLevel.IncludeItemUnit)
                    {
                        query = query.Include(y => y.ItemUnit);
                        if (detailLevel.ItemUnitDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                        if (detailLevel.ItemUnitDetailLevel.IncludeUnit)
                        {
                            query = query.Include(y => y.ItemUnit).ThenInclude(m => m.Unit);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ItemPackType, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdItemPackTypeResponse>(await _ıtemPackTypeRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
