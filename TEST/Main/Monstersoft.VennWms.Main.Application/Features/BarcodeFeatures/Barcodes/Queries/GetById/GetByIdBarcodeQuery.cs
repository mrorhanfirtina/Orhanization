using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public BarcodeDetailLevel DetailLevel { get; set; }


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

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdBarcodeResponse>(await _barcodeRepository.GetAsync(x => x.Id == request.Id,
                        include: x =>
                        {
                            IQueryable<Barcode> query = x;

                            var detailLevel = request.DetailLevel;

                            if (detailLevel.IncludeDepositorCompany)
                            {
                                query = query.Include(y => y.DepositorCompany);
                            }

                            if (detailLevel.IncludeBarcodeAreas)
                            {
                                query = query.Include(y => y.BarcodeAreas);
                            }

                            if (detailLevel.IncludeBarcodePrinters)
                            {
                                query = query.Include(y => y.BarcodePrinters);

                                if (detailLevel.BarcodePrinterDetailLevel.IncludePrinter)
                                {
                                    query = query.Include(y => y.BarcodePrinters).ThenInclude(m => m.Printer);
                                }
                            }

                            var includableQuery = query as IIncludableQueryable<Barcode, object>;
                            return includableQuery;
                        },
                        withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdBarcodeResponse>(await _barcodeRepository.GetAsync(x => x.Id == request.Id,
                            withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }

                
        }
    }



}
