using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants.ReceiptAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;

public class UpdateReceiptAttributeValueCommand : IRequest<UpdatedReceiptAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptAttributeValues";

    public UpdateReceiptAttributeValueDto ReceiptAttributeValue { get; set; }


    public class UpdateReceiptAttributeValueCommandHandler : IRequestHandler<UpdateReceiptAttributeValueCommand, UpdatedReceiptAttributeValueResponse>
    {
        private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
        private readonly ReceiptAttributeValueBusinessRules _receiptAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptAttributeValueCommandHandler(IReceiptAttributeValueRepository receiptAttributeValueRepository, ReceiptAttributeValueBusinessRules receiptAttributeValueBusinessRules, IMapper mapper)
        {
            _receiptAttributeValueRepository = receiptAttributeValueRepository;
            _receiptAttributeValueBusinessRules = receiptAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptAttributeValueResponse> Handle(UpdateReceiptAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptAttributeValue.Id)
            .CheckReceiptAttributeIdExistence(request.ReceiptAttributeValue.ReceiptAttributeId)
            .CheckReceiptIdExistence(request.ReceiptAttributeValue.ReceiptId);

            ReceiptAttributeValue? currentReceiptAttributeValue = await _receiptAttributeValueRepository.GetAsync(predicate: x => x.Id == request.ReceiptAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptAttributeValue? receiptAttributeValue = _mapper.Map(request.ReceiptAttributeValue, currentReceiptAttributeValue);
            receiptAttributeValue.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedReceiptAttributeValueResponse>(await _receiptAttributeValueRepository.UpdateAsync(receiptAttributeValue));
        }
    }
}
