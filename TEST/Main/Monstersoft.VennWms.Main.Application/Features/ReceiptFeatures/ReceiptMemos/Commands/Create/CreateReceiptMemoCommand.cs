using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants.ReceiptMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Create;

public class CreateReceiptMemoCommand : IRequest<CreatedReceiptMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptMemos"];


    public CreateReceiptMemoDto ReceiptMemo { get; set; }
    public ReceiptMemosDetailLevel? DetailLevel { get; set; }


    public class CreateReceiptMemoCommandHandler : IRequestHandler<CreateReceiptMemoCommand, CreatedReceiptMemoResponse>
    {
        private readonly IReceiptMemoRepository _receiptMemoRepository;
        private readonly ReceiptMemoBusinessRules _receiptMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptMemoCommandHandler(IReceiptMemoRepository receiptMemoRepository, IMapper mapper, ReceiptMemoBusinessRules receiptMemoBusinessRules)
        {
            _receiptMemoRepository = receiptMemoRepository;
            _mapper = mapper;
            _receiptMemoBusinessRules = receiptMemoBusinessRules;
        }

        public async Task<CreatedReceiptMemoResponse> Handle(CreateReceiptMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReceiptIdExistence(request.ReceiptMemo.ReceiptId);

            ReceiptMemo receiptMemo = _mapper.Map<ReceiptMemo>(request.ReceiptMemo);
            receiptMemo.Id = Guid.NewGuid();
            receiptMemo.CreatedDate = DateTime.Now;

            await _receiptMemoRepository.AddAsync(receiptMemo);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptMemoRepository.GetAsync(predicate: x => x.Id == receiptMemo.Id,
                include: x =>
                {
                    IQueryable<ReceiptMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipt);
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptMemo, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptMemoResponse>(response);
            }
            else
            {
                var response = await _receiptMemoRepository.GetAsync(predicate: x => x.Id == receiptMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptMemoResponse>(response);
            }
        }
    }
}
