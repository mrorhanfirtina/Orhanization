using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants.ReceiptItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;

public class CreateReceiptItemMemoCommand : IRequest<CreatedReceiptItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptItemMemos";

    public CreateReceiptItemMemoDto ReceiptItemMemo { get; set; }


    public class CreateReceiptItemMemoCommandHandler : IRequestHandler<CreateReceiptItemMemoCommand, CreatedReceiptItemMemoResponse>
    {
        private readonly IReceiptItemMemoRepository _receiptItemMemoRepository;
        private readonly ReceiptItemMemoBusinessRules _receiptItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptItemMemoCommandHandler(IReceiptItemMemoRepository receiptItemMemoRepository, IMapper mapper, ReceiptItemMemoBusinessRules receiptItemMemoBusinessRules)
        {
            _receiptItemMemoRepository = receiptItemMemoRepository;
            _mapper = mapper;
            _receiptItemMemoBusinessRules = receiptItemMemoBusinessRules;
        }

        public async Task<CreatedReceiptItemMemoResponse> Handle(CreateReceiptItemMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptItemMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReceiptItemIdExistence(request.ReceiptItemMemo.ReceiptItemId);

            ReceiptItemMemo receiptItemMemo = _mapper.Map<ReceiptItemMemo>(request.ReceiptItemMemo);
            receiptItemMemo.Id = Guid.NewGuid();
            receiptItemMemo.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReceiptItemMemoResponse>(await _receiptItemMemoRepository.AddAsync(receiptItemMemo));
        }
    }

}
