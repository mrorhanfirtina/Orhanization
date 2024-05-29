using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Constants.ReceiptOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Commands.Update;

public class UpdateReceiptCommand : IRequest<UpdatedReceiptResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceipts";

    public UpdateReceiptDto Receipt { get; set; }


    public class UpdateReceiptCommandHandler : IRequestHandler<UpdateReceiptCommand, UpdatedReceiptResponse>
    {
        private readonly IReceiptRepository _receiptRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptBusinessRules _receiptBusinessRules;

        public UpdateReceiptCommandHandler(IReceiptRepository receiptRepository, IMapper mapper, ReceiptBusinessRules receiptBusinessRules)
        {
            _receiptRepository = receiptRepository;
            _mapper = mapper;
            _receiptBusinessRules = receiptBusinessRules;
        }

        public async Task<UpdatedReceiptResponse> Handle(UpdateReceiptCommand request, CancellationToken cancellationToken)
        {
            _receiptBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Receipt.Id);

            Receipt? currentReceipt = await _receiptRepository.GetAsync(predicate: x => x.Id == request.Receipt.Id,
            include: x => x.Include(y => y.ReceiptAttributeValues)
                           .Include(y => y.ReceiptMemos)
                           .Include(y => y.ReceiptItems)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItemMemos)
                           .Include(y => y.ReceiptItems).ThenInclude(z => z.ReceiptItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Receipt? receipt = _mapper.Map(request.Receipt, currentReceipt);
            receipt.UpdatedDate = DateTime.Now;

            receipt.ReceiptItems.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = receipt.CreatedDate;

                x.ReceiptItemMemos?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
                x.ReceiptItmStockAttrValues?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
            });

            receipt.ReceiptAttributeValues?.ToList().ForEach(x => { x.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });
            receipt.ReceiptMemos?.ToList().ForEach(x => { x.UpdatedDate = DateTime.Now; x.CreatedDate = receipt.CreatedDate; });

            return _mapper.Map<UpdatedReceiptResponse>(await _receiptRepository.UpdateAsync(receipt));
        }
    }
}
