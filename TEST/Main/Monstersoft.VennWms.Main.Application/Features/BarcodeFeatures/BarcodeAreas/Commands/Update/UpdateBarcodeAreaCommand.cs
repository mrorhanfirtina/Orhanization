﻿using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants.BarcodeAreaOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;

public class UpdateBarcodeAreaCommand : IRequest<UpdatedBarcodeAreaResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, BarcodeAreaOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodeAreas";

    public UpdateBarcodeAreaDto BarcodeArea { get; set; }


    public class UpdateBarcodeAreaCommandHandler : IRequestHandler<UpdateBarcodeAreaCommand, UpdatedBarcodeAreaResponse>
    {
        private readonly IBarcodeAreaRepository _barcodeAreaRepository;
        private readonly BarcodeAreaBusinessRules _barcodeAreaBusinessRules;
        private readonly IMapper _mapper;

        public UpdateBarcodeAreaCommandHandler(IBarcodeAreaRepository barcodeAreaRepository, BarcodeAreaBusinessRules barcodeAreaBusinessRules, IMapper mapper)
        {
            _barcodeAreaRepository = barcodeAreaRepository;
            _barcodeAreaBusinessRules = barcodeAreaBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedBarcodeAreaResponse> Handle(UpdateBarcodeAreaCommand request, CancellationToken cancellationToken)
        {
            _barcodeAreaBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.BarcodeArea.Id)
            .CheckBarcodeIdExistence(request.BarcodeArea.BarcodeId);

            BarcodeArea? currentBarcodeArea = await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == request.BarcodeArea.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            BarcodeArea? barcodeArea = _mapper.Map(request.BarcodeArea, currentBarcodeArea);
            barcodeArea.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedBarcodeAreaResponse>(await _barcodeAreaRepository.UpdateAsync(barcodeArea));
        }
    }
}




