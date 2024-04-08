using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Create;

public class CreateItemUnitConversionCommand : IRequest<CreatedItemUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnitConversions";

    public CreateItemUnitConversionDto ItemUnitConversion { get; set; }


    public class CreateItemUnitConversionCommandHandler : IRequestHandler<CreateItemUnitConversionCommand, CreatedItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _ıtemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _ıtemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public CreateItemUnitConversionCommandHandler(IItemUnitConversionRepository ıtemUnitConversionRepository, IMapper mapper, ItemUnitConversionBusinessRules ıtemUnitConversionBusinessRules)
        {
            _ıtemUnitConversionRepository = ıtemUnitConversionRepository;
            _mapper = mapper;
            _ıtemUnitConversionBusinessRules = ıtemUnitConversionBusinessRules;
        }

        public async Task<CreatedItemUnitConversionResponse> Handle(CreateItemUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _ıtemUnitConversionBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReferenceItemUnitIdExistence(request.ItemUnitConversion.ReferenceItemUnitId)
                .CheckConvertedItemUnitIdExistence(request.ItemUnitConversion.ConvertedItemUnitId);
            // Eğer iki id de daha önceden eklenmişse hata verecek.

            ItemUnitConversion ıtemUnitConversion = _mapper.Map<ItemUnitConversion>(request.ItemUnitConversion);
            ıtemUnitConversion.Id = Guid.NewGuid();
            ıtemUnitConversion.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedItemUnitConversionResponse>(await _ıtemUnitConversionRepository.AddAsync(ıtemUnitConversion));
        }
    }
}

