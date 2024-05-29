using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants.PrinterOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetByCode;

public class GetByCodePrinterQuery : IRequest<GetByCodePrinterResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }
    public PrinterDetailLevel DetailLevel { get; set; }


    public class GetByCodePrinterQueryHandler : IRequestHandler<GetByCodePrinterQuery, GetByCodePrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodePrinterQueryHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _mapper = mapper;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<GetByCodePrinterResponse> Handle(GetByCodePrinterQuery request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByCodePrinterResponse>(await _printerRepository.GetAsync(
                            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                            include: x =>
                            {
                                IQueryable<Printer> query = x;

                                var detailLevel = request.DetailLevel;

                                if (detailLevel.IncludeDepositorCompany)
                                {
                                    query = query.Include(y => y.DepositorCompany);
                                }

                                var includableQuery = query as IIncludableQueryable<Printer, object>;
                                return includableQuery;
                            },
                            withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));

            }
            else
            {
                return _mapper.Map<GetByCodePrinterResponse>(await _printerRepository.GetAsync(
                            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
                            withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }

                
        }
    }

}
