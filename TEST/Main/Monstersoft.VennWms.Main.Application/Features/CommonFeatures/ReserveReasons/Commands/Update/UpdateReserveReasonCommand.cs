﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants.ReserveReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;

public class UpdateReserveReasonCommand : IRequest<UpdatedReserveReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReserveReasons";
    public string[] Roles => [ Admin, User, Write, ReserveReasonOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateReserveReasonDto ReserveReason { get; set; }


    public class UpdateReserveReasonCommandHandler : IRequestHandler<UpdateReserveReasonCommand, UpdatedReserveReasonResponse>
    {
        private readonly IReserveReasonRepository _reserveReasonRepository;
        private readonly ReserveReasonBusinessRules _reserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReserveReasonCommandHandler(IReserveReasonRepository reserveReasonRepository, ReserveReasonBusinessRules reserveReasonBusinessRules, IMapper mapper)
        {
            _reserveReasonRepository = reserveReasonRepository;
            _reserveReasonBusinessRules = reserveReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReserveReasonResponse> Handle(UpdateReserveReasonCommand request, CancellationToken cancellationToken)
        {
            _reserveReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReserveReason.Id)
            .CheckCodeExistenceWhenUpdate(request.ReserveReason.Code, request.ReserveReason.Id);

            ReserveReason? currentReserveReason = await _reserveReasonRepository.GetAsync(predicate: x => x.Id == request.ReserveReason.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReserveReason? reserveReason = _mapper.Map(request.ReserveReason, currentReserveReason);
            reserveReason.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReserveReasonResponse>(await _reserveReasonRepository.UpdateAsync(reserveReason));
        }
    }
}