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

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;

public class GetByCodeBarcodeQuery : IRequest<GetByCodeBarcodeResponse>, ITransactionalRequest, ILoggableRequest,
    ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];


    public string Code { get; set; }
}


public class GetByCodeBarcodeQueryHandler : IRequestHandler<GetByCodeBarcodeQuery, GetByCodeBarcodeResponse>
{
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly BarcodeBusinessRules _barcodeBusinessRules;
    private readonly IMapper _mapper;

    public GetByCodeBarcodeQueryHandler(IBarcodeRepository barcodeRepository, DepositorBusinessRules depositorBusinessRules, BarcodeBusinessRules barcodeBusinessRules, IMapper mapper)
    {
        _barcodeRepository = barcodeRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _barcodeBusinessRules = barcodeBusinessRules;
        _mapper = mapper;
    }

    public async Task<GetByCodeBarcodeResponse> Handle(GetByCodeBarcodeQuery request, CancellationToken cancellationToken)
    {
        // Önce user ile gelen depositor id gerçekten var mı ve aktif mi kontrol edilir.
        Guid depositorId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
        Depositor depositor = await _depositorBusinessRules.DepositorIdMustBeValid(depositorId);

        // Barkod kodu geçerli mi kontrol edilir.
        await _barcodeBusinessRules.BarcodeCodeMustBeValid(request.Code, depositor.Id);
        
        // Barkod koduna ait barkod bilgisi dönülecek.
        Barcode? barcode = await _barcodeRepository.GetAsync(predicate: p => p.Code == request.Code
                                                                   && p.DepositorId == depositor.Id, withDeleted: false,
                                                                   include: p => p.Include(p => p.BarcodeAreas).Include(p => p.Printers),
                                                                   cancellationToken: cancellationToken);

        // Dönen barkod nesnesi response nesnesine map edilir.
        var response = _mapper.Map<GetByCodeBarcodeResponse>(barcode);
        response.DepositorCode = depositor.Code;

        // Cevap döner.
        return response;
    }
}
