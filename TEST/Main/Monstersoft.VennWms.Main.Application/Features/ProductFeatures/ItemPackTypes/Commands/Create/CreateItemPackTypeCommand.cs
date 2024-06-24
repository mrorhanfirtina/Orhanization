using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants.ItemPackTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;

public class CreateItemPackTypeCommand : IRequest<CreatedItemPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemPackTypes";

    public CreateItemPackTypeDto ItemPackType { get; set; }
    public ItemPackTypesDetailLevel DetailLevel { get; set; }


    public class CreateItemPackTypeCommandHandler : IRequestHandler<CreateItemPackTypeCommand, CreatedItemPackTypeResponse>
    {
        private readonly IItemPackTypeRepository _itemPackTypeRepository;
        private readonly ItemPackTypeBusinessRules _itemPackTypeBusinessRules;
        private readonly IMapper _mapper;

        public CreateItemPackTypeCommandHandler(IItemPackTypeRepository itemPackTypeRepository, IMapper mapper, ItemPackTypeBusinessRules itemPackTypeBusinessRules)
        {
            _itemPackTypeRepository = itemPackTypeRepository;
            _mapper = mapper;
            _itemPackTypeBusinessRules = itemPackTypeBusinessRules;
        }

        public async Task<CreatedItemPackTypeResponse> Handle(CreateItemPackTypeCommand request, CancellationToken cancellationToken)
        {
            _itemPackTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckItemUnitIdExistence(request.ItemPackType.ItemUnitId)
                .CheckWeightUnitIdExistence(request.ItemPackType.WeightUnitId)
                .CheckLenghtUnitIdExistence(request.ItemPackType.LenghtUnitId)
                .CheckVolumeUnitIdExistence(request.ItemPackType.VolumeUnitId);
            //Eğer tüm idlerin birebir aynı olarak eklendiği bir durum varsa hata verecek.

            ItemPackType itemPackType = _mapper.Map<ItemPackType>(request.ItemPackType);
            itemPackType.Id = Guid.NewGuid();
            itemPackType.CreatedDate = DateTime.Now;

            await _itemPackTypeRepository.AddAsync(itemPackType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == itemPackType.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedItemPackTypeResponse>(response);
            }
            else
            {
                var response = await _itemPackTypeRepository.GetAsync(predicate: x => x.Id == itemPackType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedItemPackTypeResponse>(response);
            }
        }
    }
}
