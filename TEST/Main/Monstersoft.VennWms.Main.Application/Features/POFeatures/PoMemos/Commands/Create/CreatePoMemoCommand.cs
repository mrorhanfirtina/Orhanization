using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Constants.PoMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Commands.Create;

public class CreatePoMemoCommand : IRequest<CreatedPoMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoMemos";

    public CreatePoMemoDto PoMemo { get; set; }
    public PoMemosDetailLevel DetailLevel { get; set; }


    public class CreatePoMemoCommandHandler : IRequestHandler<CreatePoMemoCommand, CreatedPoMemoResponse>
    {
        private readonly IPoMemoRepository _poMemoRepository;
        private readonly PoMemoBusinessRules _poMemoBusinessRules;
        private readonly IMapper _mapper;

        public CreatePoMemoCommandHandler(IPoMemoRepository poMemoRepository, IMapper mapper, PoMemoBusinessRules poMemoBusinessRules)
        {
            _poMemoRepository = poMemoRepository;
            _mapper = mapper;
            _poMemoBusinessRules = poMemoBusinessRules;
        }

        public async Task<CreatedPoMemoResponse> Handle(CreatePoMemoCommand request, CancellationToken cancellationToken)
        {
            _poMemoBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckPurchaseOrderIdExistence(request.PoMemo.PurchaseOrderId);

            PoMemo poMemo = _mapper.Map<PoMemo>(request.PoMemo);
            poMemo.Id = Guid.NewGuid();
            poMemo.CreatedDate = DateTime.Now;

            await _poMemoRepository.AddAsync(poMemo);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _poMemoRepository.GetAsync(predicate: x => x.Id == poMemo.Id,
                include: x =>
                {
                    IQueryable<PoMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrder);
                    }


                    var includableQuery = query as IIncludableQueryable<PoMemo, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPoMemoResponse>(response);
            }
            else
            {
                var response = await _poMemoRepository.GetAsync(predicate: x => x.Id == poMemo.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPoMemoResponse>(response);
            }
        }
    }

}
