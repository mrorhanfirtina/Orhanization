using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants.ReceiptTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetByCode;

public class GetByCodeReceiptTypeQuery : IRequest<GetByCodeReceiptTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeReceiptTypeQueryHandler : IRequestHandler<GetByCodeReceiptTypeQuery, GetByCodeReceiptTypeResponse>
    {
        private readonly IReceiptTypeRepository _receiptTypeRepository;
        private readonly ReceiptTypeBusinessRules _receiptTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReceiptTypeQueryHandler(IReceiptTypeRepository receiptTypeRepository, IMapper mapper, ReceiptTypeBusinessRules receiptTypeBusinessRules)
        {
            _receiptTypeRepository = receiptTypeRepository;
            _mapper = mapper;
            _receiptTypeBusinessRules = receiptTypeBusinessRules;
        }

        public async Task<GetByCodeReceiptTypeResponse> Handle(GetByCodeReceiptTypeQuery request, CancellationToken cancellationToken)
        {
            _receiptTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReceiptTypeResponse>(await _receiptTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Receipts),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

