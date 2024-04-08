using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
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

            return _mapper.Map<GetByIdBarcodeAreaResponse>(await _barcodeAreaRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }


}