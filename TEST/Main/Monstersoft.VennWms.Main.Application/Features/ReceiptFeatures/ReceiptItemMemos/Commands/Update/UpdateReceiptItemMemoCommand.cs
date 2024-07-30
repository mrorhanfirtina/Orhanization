using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Constants.ReceiptItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Commands.Update;

public class UpdateReceiptItemMemoCommand : IRequest<UpdatedReceiptItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptItemMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptItemMemos"];

    public UpdateReceiptItemMemoDto ReceiptItemMemo { get; set; }
    public ReceiptItemMemosDetailLevel? DetailLevel { get; set; }


    public class UpdateReceiptItemMemoCommandHandler : IRequestHandler<UpdateReceiptItemMemoCommand, UpdatedReceiptItemMemoResponse>
    {
        private readonly IReceiptItemMemoRepository _receiptItemMemoRepository;
        private readonly ReceiptItemMemoBusinessRules _receiptItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptItemMemoCommandHandler(IReceiptItemMemoRepository receiptItemMemoRepository, ReceiptItemMemoBusinessRules receiptItemMemoBusinessRules, IMapper mapper)
        {
            _receiptItemMemoRepository = receiptItemMemoRepository;
            _receiptItemMemoBusinessRules = receiptItemMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptItemMemoResponse> Handle(UpdateReceiptItemMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptItemMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptItemMemo.Id)
            .CheckReceiptItemIdExistence(request.ReceiptItemMemo.ReceiptItemId);

            ReceiptItemMemo? currentReceiptItemMemo = await _receiptItemMemoRepository.GetAsync(predicate: x => x.Id == request.ReceiptItemMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptItemMemo? receiptItemMemo = _mapper.Map(request.ReceiptItemMemo, currentReceiptItemMemo);
            receiptItemMemo.UpdatedDate = DateTime.Now;

            await _receiptItemMemoRepository.UpdateAsync(receiptItemMemo);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptItemMemoRepository.GetAsync(predicate: x => x.Id == receiptItemMemo.Id,
                include: x =>
                {
                    IQueryable<ReceiptItemMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceiptItem)
                    {
                        query = query.Include(y => y.ReceiptItem);

                        if (detailLevel.ReceiptItemDetailLevel.IncludeReceipt)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Receipt);
                        }

                        if (detailLevel.ReceiptItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReceiptItem).ThenInclude(y => y.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptItemMemo, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItemMemoResponse>(response);
            }
            else
            {
                var response = await _receiptItemMemoRepository.GetAsync(predicate: x => x.Id == receiptItemMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptItemMemoResponse>(response);
            }
        }
    }
}
