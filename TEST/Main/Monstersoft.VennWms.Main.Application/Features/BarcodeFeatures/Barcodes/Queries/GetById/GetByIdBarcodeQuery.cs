using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
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


    public class GetByIdBarcodeQueryHandler : IRequestHandler<GetByIdBarcodeQuery, GetByIdBarcodeResponse>
    {
        private readonly IBarcodeRepository _barcodeRepository;
        private readonly BarcodeBusinessRules _barcodeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBarcodeQueryHandler(IBarcodeRepository barcodeRepository, IMapper mapper, BarcodeBusinessRules barcodeBusinessRules)
        {
            _barcodeRepository = barcodeRepository;
            _mapper = mapper;
            _barcodeBusinessRules = barcodeBusinessRules;
        }

        public async Task<GetByIdBarcodeResponse> Handle(GetByIdBarcodeQuery request, CancellationToken cancellationToken)
        {
            _barcodeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdBarcodeResponse>(await _barcodeRepository.GetAsync(x => x.Id == request.Id, 
                include: m => m.Include(m => m.BarcodeAreas).Include(m => m.BarcodePrinters), 
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }



}
