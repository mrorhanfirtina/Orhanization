using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;

public class CreateReceiptItmStockAttrValueCommand : IRequest<CreatedReceiptItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItmStockAttrValues";

    public CreateReceiptItmStockAttrValueDto ReceiptItmStockAttrValue { get; set; }


    public class CreateReceiptItmStockAttrValueCommandHandler : IRequestHandler<CreateReceiptItmStockAttrValueCommand, CreatedReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptItmStockAttrValueCommandHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, IMapper mapper, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _mapper = mapper;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
        }

        public async Task<CreatedReceiptItmStockAttrValueResponse> Handle(CreateReceiptItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReceiptItemIdExistence(request.ReceiptItmStockAttrValue.ReceiptItemId)
                .CheckStockAttributeIdExistence(request.ReceiptItmStockAttrValue.StockAttributeId);

            ReceiptItmStockAttrValue receiptItmStockAttrValue = _mapper.Map<ReceiptItmStockAttrValue>(request.ReceiptItmStockAttrValue);
            receiptItmStockAttrValue.Id = Guid.NewGuid();
            receiptItmStockAttrValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReceiptItmStockAttrValueResponse>(await _receiptItmStockAttrValueRepository.AddAsync(receiptItmStockAttrValue));
        }
    }
}

