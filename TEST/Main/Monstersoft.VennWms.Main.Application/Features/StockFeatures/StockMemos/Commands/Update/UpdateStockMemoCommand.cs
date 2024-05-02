﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Constants.StockMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockMemos.Commands.Update;

public class UpdateStockMemoCommand : IRequest<UpdatedStockMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockMemoOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockMemos";

    public UpdateStockMemoDto StockMemo { get; set; }


    public class UpdateStockMemoCommandHandler : IRequestHandler<UpdateStockMemoCommand, UpdatedStockMemoResponse>
    {
        private readonly IStockMemoRepository _stockMemoRepository;
        private readonly StockMemoBusinessRules _stockMemoBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockMemoCommandHandler(IStockMemoRepository stockMemoRepository, StockMemoBusinessRules stockMemoBusinessRules, IMapper mapper)
        {
            _stockMemoRepository = stockMemoRepository;
            _stockMemoBusinessRules = stockMemoBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockMemoResponse> Handle(UpdateStockMemoCommand request, CancellationToken cancellationToken)
        {
            _stockMemoBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockMemo.Id)
            .CheckStockIdExistence(request.StockMemo.StockId);

            StockMemo? currentStockMemo = await _stockMemoRepository.GetAsync(predicate: x => x.Id == request.StockMemo.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockMemo? stockMemo = _mapper.Map(request.StockMemo, currentStockMemo);
            stockMemo.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStockMemoResponse>(await _stockMemoRepository.UpdateAsync(stockMemo));
        }
    }
}