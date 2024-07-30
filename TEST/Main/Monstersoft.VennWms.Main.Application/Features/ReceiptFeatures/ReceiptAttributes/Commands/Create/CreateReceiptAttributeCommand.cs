using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;

public class CreateReceiptAttributeCommand : IRequest<CreatedReceiptAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptAttributes"];


    public CreateReceiptAttributeDto ReceiptAttribute { get; set; }
    public ReceiptAttributesDetailLevel? DetailLevel { get; set; }


    public class CreateReceiptAttributeCommandHandler : IRequestHandler<CreateReceiptAttributeCommand, CreatedReceiptAttributeResponse>
    {
        private readonly IReceiptAttributeRepository _receiptAttributeRepository;
        private readonly ReceiptAttributeBusinessRules _receiptAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreateReceiptAttributeCommandHandler(IReceiptAttributeRepository receiptAttributeRepository, IMapper mapper, ReceiptAttributeBusinessRules receiptAttributeBusinessRules)
        {
            _receiptAttributeRepository = receiptAttributeRepository;
            _mapper = mapper;
            _receiptAttributeBusinessRules = receiptAttributeBusinessRules;
        }

        public async Task<CreatedReceiptAttributeResponse> Handle(CreateReceiptAttributeCommand request, CancellationToken cancellationToken)
        {
            _receiptAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckAttributeInputTypeIdExistence(request.ReceiptAttribute.AttributeInputTypeId)
                .CheckCodeExistenceWhenCreate(request.ReceiptAttribute.Code);

            ReceiptAttribute receiptAttribute = _mapper.Map<ReceiptAttribute>(request.ReceiptAttribute);
            receiptAttribute.Id = Guid.NewGuid();
            receiptAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            receiptAttribute.CreatedDate = DateTime.Now;

            await _receiptAttributeRepository.AddAsync(receiptAttribute);

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

                return _mapper.Map<CreatedReceiptAttributeResponse>(response);
            }
            else
            {
                var response = await _receiptAttributeRepository.GetAsync(predicate: x => x.Id == receiptAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptAttributeResponse>(response);
            }
        }
    }

}

