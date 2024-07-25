using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants.ReceiptAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Update;

public class UpdateReceiptAttributeCommand : IRequest<UpdatedReceiptAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptAttributes"];

    public UpdateReceiptAttributeDto ReceiptAttribute { get; set; }
    public ReceiptAttributesDetailLevel? DetailLevel { get; set; }


    public class UpdateReceiptAttributeCommandHandler : IRequestHandler<UpdateReceiptAttributeCommand, UpdatedReceiptAttributeResponse>
    {
        private readonly IReceiptAttributeRepository _receiptAttributeRepository;
        private readonly ReceiptAttributeBusinessRules _receiptAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReceiptAttributeCommandHandler(IReceiptAttributeRepository receiptAttributeRepository, ReceiptAttributeBusinessRules receiptAttributeBusinessRules, IMapper mapper)
        {
            _receiptAttributeRepository = receiptAttributeRepository;
            _receiptAttributeBusinessRules = receiptAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReceiptAttributeResponse> Handle(UpdateReceiptAttributeCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReceiptAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.ReceiptAttribute.AttributeInputTypeId)
            .CheckCodeExistenceWhenUpdate(request.ReceiptAttribute.Code, request.ReceiptAttribute.Id);

            ReceiptAttribute? currentReceiptAttribute = await _receiptAttributeRepository.GetAsync(predicate: x => x.Id == request.ReceiptAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReceiptAttribute? receiptAttribute = _mapper.Map(request.ReceiptAttribute, currentReceiptAttribute);
            receiptAttribute.UpdatedDate = DateTime.Now;

            await _receiptAttributeRepository.UpdateAsync(receiptAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptAttributeRepository.GetAsync(predicate: x => x.Id == receiptAttribute.Id,
                include: x =>
                {
                    IQueryable<ReceiptAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }


                    var includableQuery = query as IIncludableQueryable<ReceiptAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptAttributeResponse>(response);
            }
            else
            {
                var response = await _receiptAttributeRepository.GetAsync(predicate: x => x.Id == receiptAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptAttributeResponse>(response);
            }
        }
    }
}

