using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public string? CacheGroupKey => "GetBarcodes";

    public CreateBarcodeAreaDto BarcodeArea { get; set; }
    public BarcodeAreasDetailLevel DetailLevel { get; set; }


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

            await _barcodeAreaRepository.AddAsync(barcodeArea);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == barcodeArea.Id,
                include: x =>
                {
                    IQueryable<BarcodeArea> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeBarcode)
                    {
                        query = query.Include(y => y.Barcode);

                        if (detailLevel.BarcodeDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Barcode.DepositorCompany);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<BarcodeArea, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodeAreaResponse>(response);
            }
            else
            {
                var response = await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == barcodeArea.Id, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedBarcodeAreaResponse>(response);
            }
        }
    }
}


