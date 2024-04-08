using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
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


    public class GetByCodeBarcodeQueryHandler : IRequestHandler<GetByCodeBarcodeQuery, GetByCodeBarcodeResponse>
    {
        private readonly IBarcodeRepository _barcodeRepository;
        private readonly BarcodeBusinessRules _barcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeBarcodeQueryHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules)
        {
            _barcodeRepository = barcodeRepository;
            _mapper = mapper;
            _barcodeBusinessRules = barcodeBusinessRules;
        }

        public async Task<GetByCodeBarcodeResponse> Handle(GetByCodeBarcodeQuery request, CancellationToken cancellationToken)
        {
            _barcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeBarcodeResponse>(await _barcodeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include( m => m.BarcodeAreas).Include(m => m.BarcodePrinters),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }
}


