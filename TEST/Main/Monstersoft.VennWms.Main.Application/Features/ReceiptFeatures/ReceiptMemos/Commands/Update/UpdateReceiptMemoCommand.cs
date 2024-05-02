﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Constants.ReceiptMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Commands.Update;

public class UpdateReceiptMemoCommand : IRequest<UpdatedReceiptMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptMemos";

    public UpdateReceiptMemoDto ReceiptMemo { get; set; }


    public class UpdateReceiptMemoCommandHandler : IRequestHandler<UpdateReceiptMemoCommand, UpdatedReceiptMemoResponse>
    {
        private readonly IReceiptMemoRepository _receiptMemoRepository;
        private readonly ReceiptMemoBusinessRules _receiptMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptMemoCommandHandler(IReceiptMemoRepository receiptMemoRepository, ReceiptMemoBusinessRules receiptMemoBusinessRules, IMapper mapper)
        {
            _receiptMemoRepository = receiptMemoRepository;
            _receiptMemoBusinessRules = receiptMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptMemoResponse> Handle(UpdateReceiptMemoCommand request, CancellationToken cancellationToken)
        {
            _receiptMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptMemo.Id)
            .CheckReceiptIdExistence(request.ReceiptMemo.ReceiptId);

            ReceiptMemo? currentReceiptMemo = await _receiptMemoRepository.GetAsync(predicate: x => x.Id == request.ReceiptMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptMemo? receiptMemo = _mapper.Map(request.ReceiptMemo, currentReceiptMemo);
            receiptMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReceiptMemoResponse>(await _receiptMemoRepository.UpdateAsync(receiptMemo));
        }
    }
}