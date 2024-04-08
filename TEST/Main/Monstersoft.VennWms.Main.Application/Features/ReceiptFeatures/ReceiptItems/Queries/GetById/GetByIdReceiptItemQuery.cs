using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants.ReceiptItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetById;

public class GetByIdReceiptItemQuery : IRequest<GetByIdReceiptItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReceiptItemQueryHandler : IRequestHandler<GetByIdReceiptItemQuery, GetByIdReceiptItemResponse>
    {
        private readonly IReceiptItemRepository _receiptItemRepository;
        private readonly ReceiptItemBusinessRules _receiptItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReceiptItemQueryHandler(IReceiptItemRepository receiptItemRepository, IMapper mapper, ReceiptItemBusinessRules receiptItemBusinessRules)
        {
            _receiptItemRepository = receiptItemRepository;
            _mapper = mapper;
            _receiptItemBusinessRules = receiptItemBusinessRules;
        }

        public async Task<GetByIdReceiptItemResponse> Handle(GetByIdReceiptItemQuery request, CancellationToken cancellationToken)
        {
            _receiptItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReceiptItemResponse>(await _receiptItemRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.ReceiptItemMemos).Include(x => x.ReceiptItmStockAttrValues),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
