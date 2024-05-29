using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Create;

public class CreateReceiptCommand : IRequest<CreatedReceiptResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceipts";

    public CreateReceiptDto Receipt { get; set; }


    public class CreateReceiptCommandHandler : IRequestHandler<CreateReceiptCommand, CreatedReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptBusinessRules _receiptBusinessRules;

        public CreateReceiptCommandHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<CreatedReceiptResponse> Handle(CreateReceiptCommand request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Receipt? receipt = _mapper.Map<Receipt>(request.Receipt);

            receipt.CreatedDate = DateTime.Now;
            receipt.Id = Guid.NewGuid();
            receipt.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            receipt.ReceiptMemos.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            receipt.ReceiptAttributeValues.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            receipt.ReceiptItems.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.ReceiptItemMemos?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
                x.ReceiptItmStockAttrValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
            });

            return _mapper.Map<CreatedReceiptResponse>(await _receiptRepository.AddAsync(receipt));
        }
    }
}
