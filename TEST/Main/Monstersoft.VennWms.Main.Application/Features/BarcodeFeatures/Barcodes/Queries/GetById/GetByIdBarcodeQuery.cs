using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;

public class GetByIdBarcodeQuery : IRequest<GetByIdBarcodeResponse>, ITransactionalRequest, 
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
}

public class GetByIdBarcodeQueryHandler : IRequestHandler<GetByIdBarcodeQuery, GetByIdBarcodeResponse>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly IMapper _mapper;

    public GetByIdBarcodeQueryHandler(IBarcodeRepository barcodeRepository, DepositorBusinessRules depositorBusinessRules, BarcodeBusinessRules barcodeBusinessRules, IMapper mapper)
    {
        _barcodeRepository = barcodeRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _barcodeBusinessRules = barcodeBusinessRules;
        _mapper = mapper;
    }

    public async Task<GetByIdBarcodeResponse> Handle(GetByIdBarcodeQuery request, CancellationToken cancellationToken)
    {
        // Kullanıcı ile gelen depositor id gerçekten var mı ve aktif mi kontrol edilir.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        Depositor depositor = await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);

        // Barkod id gerçekten var mı ve aktif mi kontrol edilir.
        await _barcodeBusinessRules.BarcodeIdMustBeValid(request.Id, depositorId);

        // Barkod bilgisi alınır.
        Barcode? barcode = await _barcodeRepository.GetAsync(predicate: p => p.Id == request.Id && p.DepositorId == depositorId, withDeleted: false,
                                                                              include: p => p.Include(p => p.BarcodeAreas).Include(p => p.Printers),cancellationToken: cancellationToken);

        
        // Barkod bilgisi response dto suna map edilir.
        var response = _mapper.Map<GetByIdBarcodeResponse>(barcode);
        response.DepositorCode = depositor.Code;

        // Sonuç döner.
        return response;
    }
}
