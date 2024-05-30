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


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetById;

public class GetByIdPrinterQuery : IRequest<GetByIdPrinterResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public PrintersDetailLevel DetailLevel { get; set; }


    public class GetByIdPrinterQueryHandler : IRequestHandler<GetByIdPrinterQuery, GetByIdPrinterResponse>
    {
        private readonly IPrinterRepository _printerRepository;
        private readonly PrinterBusinessRules _printerBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdPrinterQueryHandler(IPrinterRepository printerRepository, IMapper mapper, PrinterBusinessRules printerBusinessRules)
        {
            _printerRepository = printerRepository;
            _mapper = mapper;
            _printerBusinessRules = printerBusinessRules;
        }

        public async Task<GetByIdPrinterResponse> Handle(GetByIdPrinterQuery request, CancellationToken cancellationToken)
        {
            _printerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdPrinterResponse>(await _printerRepository.GetAsync(x => x.Id == request.Id,
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
                return _mapper.Map<GetByIdPrinterResponse>(await _printerRepository.GetAsync(x => x.Id == request.Id,
                    withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }

                
        }
    }

}
