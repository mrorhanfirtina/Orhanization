using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants.ReceiptTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;

public class CreateReceiptTypeCommand : IRequest<CreatedReceiptTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReceiptTypes";

    public CreateReceiptTypeDto ReceiptType { get; set; }
    public ReceiptTypesDetailLevel? DetailLevel { get; set; }

    public class CreateReceiptTypeCommandHandler : IRequestHandler<CreateReceiptTypeCommand, CreatedReceiptTypeResponse>
    {
        private readonly IReceiptTypeRepository _receiptTypeRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptTypeBusinessRules _receiptTypeBusinessRules;

        public CreateReceiptTypeCommandHandler(IReceiptTypeRepository receiptTypeRepository, IMapper mapper, ReceiptTypeBusinessRules receiptTypeBusinessRules)
        {
            _receiptTypeRepository = receiptTypeRepository;
            _mapper = mapper;
            _receiptTypeBusinessRules = receiptTypeBusinessRules;
        }

        public async Task<CreatedReceiptTypeResponse> Handle(CreateReceiptTypeCommand request, CancellationToken cancellationToken)
        {
            _receiptTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ReceiptType.Code);

            ReceiptType? receiptType = _mapper.Map<ReceiptType>(request.ReceiptType);

            receiptType.CreatedDate = DateTime.Now;
            receiptType.Id = Guid.NewGuid();
            receiptType.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            await _receiptTypeRepository.AddAsync(receiptType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == receiptType.Id,
                include: x =>
                {
                    IQueryable<ReceiptType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReceipt)
                    {
                        query = query.Include(y => y.Receipts);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ReceiptType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptTypeResponse>(response);
            }
            else
            {
                var response = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == receiptType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReceiptTypeResponse>(response);
            }
        }
    }
}

