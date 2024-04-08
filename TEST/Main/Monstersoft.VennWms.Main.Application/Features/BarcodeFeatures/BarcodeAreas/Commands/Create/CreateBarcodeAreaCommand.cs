using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Create;

public class CreateBarcodeAreaCommand : IRequest<CreatedBarcodeAreaResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{ 
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetBarcodeAreas";

    public CreateBarcodeAreaDto BarcodeArea { get; set; }


    public class CreateBarcodeAreaCommandHandler : IRequestHandler<CreateBarcodeAreaCommand, CreatedBarcodeAreaResponse>
    {
        private readonly IBarcodeAreaRepository _barcodeAreaRepository;
        private readonly BarcodeAreaBusinessRules _barcodeAreaBusinessRules;
        private readonly IMapper _mapper;

        public CreateBarcodeAreaCommandHandler(IBarcodeAreaRepository barcodeAreaRepository, IMapper mapper, BarcodeAreaBusinessRules barcodeAreaBusinessRules)
        {
            _barcodeAreaRepository = barcodeAreaRepository;
            _mapper = mapper;
            _barcodeAreaBusinessRules = barcodeAreaBusinessRules;
        }

        public async Task<CreatedBarcodeAreaResponse> Handle(CreateBarcodeAreaCommand request, CancellationToken cancellationToken)
        {
            _barcodeAreaBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckBarcodeIdExistence(request.BarcodeArea.BarcodeId);

            BarcodeArea barcodeArea = _mapper.Map<BarcodeArea>(request.BarcodeArea);
            barcodeArea.Id = Guid.NewGuid();
            barcodeArea.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedBarcodeAreaResponse>(await _barcodeAreaRepository.AddAsync(barcodeArea));
        }
    }
}


