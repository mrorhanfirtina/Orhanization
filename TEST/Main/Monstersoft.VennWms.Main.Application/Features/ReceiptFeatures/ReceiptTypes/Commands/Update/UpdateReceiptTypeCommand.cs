using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;

public class UpdateReceiptTypeCommand : IRequest<UpdatedReceiptTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReceiptTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReceiptTypes"];

    public UpdateReceiptTypeDto ReceiptType { get; set; }
    public ReceiptTypesDetailLevel? DetailLevel { get; set; }


    public class UpdateReceiptTypeCommandHandler : IRequestHandler<UpdateReceiptTypeCommand, UpdatedReceiptTypeResponse>
    {
        private readonly IReceiptTypeRepository _receiptTypeRepository;
        private readonly IMapper _mapper;
        private readonly ReceiptTypeBusinessRules _receiptTypeBusinessRules;

        public UpdateReceiptTypeCommandHandler(IReceiptTypeRepository receiptTypeRepository, IMapper mapper, ReceiptTypeBusinessRules receiptTypeBusinessRules)
        {
            _receiptTypeRepository = receiptTypeRepository;
            _mapper = mapper;
            _receiptTypeBusinessRules = receiptTypeBusinessRules;
        }

        public async Task<UpdatedReceiptTypeResponse> Handle(UpdateReceiptTypeCommand request, CancellationToken cancellationToken)
        {
            _receiptTypeBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckIdExistence(request.ReceiptType.Id)
                .CheckCodeExistenceWhenUpdate(request.ReceiptType.Code, Guid.Parse(request.UserRequestInfo.RequestUserLocalityId));

            ReceiptType? currentReceiptType = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == request.ReceiptType.Id,
            withDeleted: false, enableTracking: true, cancellationToken: cancellationToken);

            ReceiptType updatedReceiptType = _mapper.Map(request.ReceiptType, currentReceiptType);

            updatedReceiptType.UpdatedDate = DateTime.Now;

            await _receiptTypeRepository.UpdateAsync(updatedReceiptType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == updatedReceiptType.Id,
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

                return _mapper.Map<UpdatedReceiptTypeResponse>(response);
            }
            else
            {
                var response = await _receiptTypeRepository.GetAsync(predicate: x => x.Id == updatedReceiptType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReceiptTypeResponse>(response);
            }
        }
    }
}

