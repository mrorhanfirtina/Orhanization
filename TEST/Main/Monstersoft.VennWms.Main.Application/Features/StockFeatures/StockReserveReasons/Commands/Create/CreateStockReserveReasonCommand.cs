﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants.StockReserveReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Commands.Create;

public class CreateStockReserveReasonCommand : IRequest<CreatedStockReserveReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockReserveReasons";

    public CreateStockReserveReasonDto StockReserveReason { get; set; }


    public class CreateStockReserveReasonCommandHandler : IRequestHandler<CreateStockReserveReasonCommand, CreatedStockReserveReasonResponse>
    {
        private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
        private readonly StockReserveReasonBusinessRules _stockReserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateStockReserveReasonCommandHandler(IStockReserveReasonRepository stockReserveReasonRepository, IMapper mapper, StockReserveReasonBusinessRules stockReserveReasonBusinessRules)
        {
            _stockReserveReasonRepository = stockReserveReasonRepository;
            _mapper = mapper;
            _stockReserveReasonBusinessRules = stockReserveReasonBusinessRules;
        }

        public async Task<CreatedStockReserveReasonResponse> Handle(CreateStockReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _stockReserveReasonBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckStockIdExistence(request.StockReserveReason.StockId)
                .CheckReserveReasonIdExistence(request.StockReserveReason.ReserveReasonId);

            StockReserveReason stockReserveReason = _mapper.Map<StockReserveReason>(request.StockReserveReason);
            stockReserveReason.Id = Guid.NewGuid();
            stockReserveReason.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedStockReserveReasonResponse>(await _stockReserveReasonRepository.AddAsync(stockReserveReason));
        }
    }
}

