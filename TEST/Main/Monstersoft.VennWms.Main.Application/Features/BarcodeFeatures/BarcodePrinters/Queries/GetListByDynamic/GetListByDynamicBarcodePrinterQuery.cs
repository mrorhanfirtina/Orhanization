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
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants.BarcodePrinterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetListByDynamic;

public class GetListByDynamicBarcodePrinterQuery : IRequest<GetListResponse<GetListByDynamicBarcodePrinterListItemDto>>, ITransactionalRequest,
    ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, BarcodePrinterOperationClaims.User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public BarcodePrintersDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicBarcodePrinterQueryHandler : IRequestHandler<GetListByDynamicBarcodePrinterQuery, GetListResponse<GetListByDynamicBarcodePrinterListItemDto>>
    {
        private readonly IBarcodePrinterRepository _barcodePrinterRepository;
        private readonly BarcodePrinterBusinessRules _barcodePrinterBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBarcodePrinterQueryHandler(IBarcodePrinterRepository barcodePrinterRepository, IMapper mapper, BarcodePrinterBusinessRules barcodePrinterBusinessRules)
        {
            _barcodePrinterRepository = barcodePrinterRepository;
            _barcodePrinterBusinessRules = barcodePrinterBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBarcodePrinterListItemDto>> Handle(GetListByDynamicBarcodePrinterQuery request, CancellationToken cancellationToken)
        {
            _barcodePrinterBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<BarcodePrinter> barcodePrinterList = await _barcodePrinterRepository.GetListByDynamicAsync(
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
                    dynamic: request.DynamicQuery,
                    index: request.PageRequest.PageIndex,
                    size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBarcodePrinterListItemDto>>(barcodePrinterList);
            }
            else
            {
                Paginate<BarcodePrinter> barcodePrinterList = await _barcodePrinterRepository.GetListByDynamicAsync(
                    dynamic: request.DynamicQuery,
                    enableTracking: false,
                    index: request.PageRequest.PageIndex,
                    size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicBarcodePrinterListItemDto>>(barcodePrinterList);
            }

            
        }
    }

}
