using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants.ReceiptItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Update;

public class UpdateReceiptItmStockAttrValueCommand : IRequest<UpdatedReceiptItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptItemStockAttrValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItmStockAttrValues";

    public UpdateReceiptItmStockAttrValueDto ReceiptItmStockAttrValue { get; set; }


    public class UpdateReceiptItmStockAttrValueCommandHandler : IRequestHandler<UpdateReceiptItmStockAttrValueCommand, UpdatedReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptItmStockAttrValueCommandHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules, IMapper mapper)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptItmStockAttrValueResponse> Handle(UpdateReceiptItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptItmStockAttrValue.Id)
            .CheckReceiptItemIdExistence(request.ReceiptItmStockAttrValue.ReceiptItemId)
            .CheckStockAttributeIdExistence(request.ReceiptItmStockAttrValue.StockAttributeId);

            ReceiptItmStockAttrValue? currentReceiptItmStockAttrValue = await _receiptItmStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.ReceiptItmStockAttrValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptItmStockAttrValue? receiptItmStockAttrValue = _mapper.Map(request.ReceiptItmStockAttrValue, currentReceiptItmStockAttrValue);
            receiptItmStockAttrValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReceiptItmStockAttrValueResponse>(await _receiptItmStockAttrValueRepository.UpdateAsync(receiptItmStockAttrValue));
        }
    }
}

