using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Update;

public class UpdateItemUnitConversionCommand : IRequest<UpdatedItemUnitConversionResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ItemUnitConversionOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetItemUnitConversions";

    public UpdateItemUnitConversionDto ItemUnitConversion { get; set; }


    public class UpdateItemUnitConversionCommandHandler : IRequestHandler<UpdateItemUnitConversionCommand, UpdatedItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _ıtemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _ıtemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public UpdateItemUnitConversionCommandHandler(IItemUnitConversionRepository ıtemUnitConversionRepository, ItemUnitConversionBusinessRules ıtemUnitConversionBusinessRules, IMapper mapper)
        {
            _ıtemUnitConversionRepository = ıtemUnitConversionRepository;
            _ıtemUnitConversionBusinessRules = ıtemUnitConversionBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedItemUnitConversionResponse> Handle(UpdateItemUnitConversionCommand request, CancellationToken cancellationToken)
        {
            _ıtemUnitConversionBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ItemUnitConversion.Id)
            .CheckConvertedItemUnitIdExistence(request.ItemUnitConversion.ConvertedItemUnitId)
            .CheckReferenceItemUnitIdExistence(request.ItemUnitConversion.ReferenceItemUnitId);

            ItemUnitConversion? currentItemUnitConversion = await _ıtemUnitConversionRepository.GetAsync(predicate: x => x.Id == request.ItemUnitConversion.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ItemUnitConversion? ıtemUnitConversion = _mapper.Map(request.ItemUnitConversion, currentItemUnitConversion);
            ıtemUnitConversion.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedItemUnitConversionResponse>(await _ıtemUnitConversionRepository.UpdateAsync(ıtemUnitConversion));
        }
    }
}

