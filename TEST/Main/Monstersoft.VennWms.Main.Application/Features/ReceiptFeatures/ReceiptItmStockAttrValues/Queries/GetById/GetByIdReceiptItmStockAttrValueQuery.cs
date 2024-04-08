using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants.ReceiptItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Queries.GetById;

public class GetByIdReceiptItmStockAttrValueQuery : IRequest<GetByIdReceiptItmStockAttrValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReceiptItmStockAttrValueQueryHandler : IRequestHandler<GetByIdReceiptItmStockAttrValueQuery, GetByIdReceiptItmStockAttrValueResponse>
    {
        private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
        private readonly ReceiptItmStockAttrValueBusinessRules _receiptItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptItmStockAttrValueQueryHandler(IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, IMapper mapper, ReceiptItmStockAttrValueBusinessRules receiptItmStockAttrValueBusinessRules)
        {
            _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
            _mapper = mapper;
            _receiptItmStockAttrValueBusinessRules = receiptItmStockAttrValueBusinessRules;
        }

        public async Task<GetByIdReceiptItmStockAttrValueResponse> Handle(GetByIdReceiptItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _receiptItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReceiptItmStockAttrValueResponse>(await _receiptItmStockAttrValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

