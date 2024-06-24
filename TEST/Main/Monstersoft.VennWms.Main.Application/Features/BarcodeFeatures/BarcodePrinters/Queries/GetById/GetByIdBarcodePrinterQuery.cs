using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants.BarcodePrinterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetById;

public class GetByIdBarcodePrinterQuery : IRequest<GetByIdBarcodePrinterResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public BarcodePrintersDetailLevel DetailLevel { get; set; }


    public class GetByIdBarcodePrinterQueryHandler : IRequestHandler<GetByIdBarcodePrinterQuery, GetByIdBarcodePrinterResponse>
    {
        private readonly IBarcodePrinterRepository _barcodePrinterRepository;
        private readonly BarcodePrinterBusinessRules _barcodePrinterBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBarcodePrinterQueryHandler(IBarcodePrinterRepository barcodePrinterRepository, IMapper mapper, BarcodePrinterBusinessRules barcodePrinterBusinessRules)
        {
            _barcodePrinterRepository = barcodePrinterRepository;
            _mapper = mapper;
            _barcodePrinterBusinessRules = barcodePrinterBusinessRules;
        }

        public async Task<GetByIdBarcodePrinterResponse> Handle(GetByIdBarcodePrinterQuery request, CancellationToken cancellationToken)
        {
            _barcodePrinterBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdBarcodePrinterResponse>(await _barcodePrinterRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<BarcodePrinter> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeBarcode)
                    {
                        query = query.Include(y => y.Barcode);

                        if (detailLevel.BarcodeDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Barcode.DepositorCompany);
                        }
                    }

                    if (detailLevel.IncludePrinter)
                    {
                        query = query.Include(y => y.Printer);
                    }

                    var includableQuery = query as IIncludableQueryable<BarcodePrinter, object>;
                    return includableQuery;
                }, enableTracking: false,
                withDeleted: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBarcodePrinterResponse>(await _barcodePrinterRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }


        }
    }

}
