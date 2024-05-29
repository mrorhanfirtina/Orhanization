using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Commands.Create;

public class CreateReceiptItemCommand : IRequest<CreatedReceiptItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItems";

    public CreateReceiptItemDto ReceiptItem { get; set; }


    public class CreateReceiptItemCommandHandler : IRequestHandler<CreateReceiptItemCommand, CreatedReceiptItemResponse>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;

        public CreateReceiptItemCommandHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _mapper = mapper;
            _receiptItemBusinessRules = receiptItemBusinessRules;
        }

        public async Task<CreatedReceiptItemResponse> Handle(CreateReceiptItemCommand request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            ReceiptItem? receiptItem = _mapper.Map<ReceiptItem>(request.ReceiptItem);

            receiptItem.CreatedDate = DateTime.Now;

            receiptItem.ReceiptItemMemos?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            receiptItem.ReceiptItmStockAttrValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            return _mapper.Map<CreatedReceiptItemResponse>(await _receiptItemRepository.AddAsync(receiptItem));
        }
    }
}
