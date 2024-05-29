using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants.BarcodeAreaOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetById;

public class GetByIdBarcodeAreaQuery : IRequest<GetByIdBarcodeAreaResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public BarcodeAreaDetailLevel DetailLevel { get; set; }


    public class GetByIdBarcodeAreaQueryHandler : IRequestHandler<GetByIdBarcodeAreaQuery, GetByIdBarcodeAreaResponse>
    {
        private readonly IBarcodeAreaRepository _barcodeAreaRepository;
        private readonly BarcodeAreaBusinessRules _barcodeAreaBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdBarcodeAreaQueryHandler(IBarcodeAreaRepository barcodeAreaRepository, IMapper mapper, BarcodeAreaBusinessRules barcodeAreaBusinessRules)
        {
            _barcodeAreaRepository = barcodeAreaRepository;
            _mapper = mapper;
            _barcodeAreaBusinessRules = barcodeAreaBusinessRules;
        }

        public async Task<GetByIdBarcodeAreaResponse> Handle(GetByIdBarcodeAreaQuery request, CancellationToken cancellationToken)
        {
            _barcodeAreaBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = _mapper.Map<GetByIdBarcodeAreaResponse>(await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<BarcodeArea> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeBarcode)
                    {
                        query = query.Include(y => y.Barcode);

                        if (detailLevel.BarcodeDetailLevel.IncludeDepositorCompany)
                        {
                            query = query.Include(y => y.Barcode).ThenInclude(m => m.DepositorCompany);
                        }
                    }
                    var includableQuery = query as IIncludableQueryable<BarcodeArea, object>;

                    return includableQuery;

                }, enableTracking: false, cancellationToken: cancellationToken, withDeleted: false));

                return response;
            }
            else
            {
                var response = await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == request.Id, enableTracking: false, cancellationToken: cancellationToken, withDeleted: false);

                return _mapper.Map<GetByIdBarcodeAreaResponse>(response);
            }
        }
    }


}