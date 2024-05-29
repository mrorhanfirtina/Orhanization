using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants.PoAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Commands.Update;

public class UpdatePoAttributeValueCommand : IRequest<UpdatedPoAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributeValues";

    public UpdatePoAttributeValueDto PoAttributeValue { get; set; }
    public PoAttributeValueDetailLevel DetailLevel { get; set; }


    public class UpdatePoAttributeValueCommandHandler : IRequestHandler<UpdatePoAttributeValueCommand, UpdatedPoAttributeValueResponse>
    {
        private readonly IPoAttributeValueRepository _poAttributeValueRepository;
        private readonly PoAttributeValueBusinessRules _poAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePoAttributeValueCommandHandler(IPoAttributeValueRepository poAttributeValueRepository, PoAttributeValueBusinessRules poAttributeValueBusinessRules, IMapper mapper)
        {
            _poAttributeValueRepository = poAttributeValueRepository;
            _poAttributeValueBusinessRules = poAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPoAttributeValueResponse> Handle(UpdatePoAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _poAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.PoAttributeValue.Id)
            .CheckPurchaseOrderIdExistence(request.PoAttributeValue.PurchaseOrderId)
            .CheckPoAttributeIdExistence(request.PoAttributeValue.PoAttributeId);

            PoAttributeValue? currentPoAttributeValue = await _poAttributeValueRepository.GetAsync(predicate: x => x.Id == request.PoAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            PoAttributeValue? poAttributeValue = _mapper.Map(request.PoAttributeValue, currentPoAttributeValue);
            poAttributeValue.UpdatedDate = DateTime.Now;

            await _poAttributeValueRepository.UpdateAsync(poAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _poAttributeValueRepository.GetAsync(predicate: x => x.Id == poAttributeValue.Id,
                include: x =>
                {
                    IQueryable<PoAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrder);
                    }

                    if (detailLevel.IncludePoAttribute)
                    {
                        query = query.Include(y => y.PoAttribute);

                        if (detailLevel.PoAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.PoAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<PoAttributeValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedPoAttributeValueResponse>(response);
            }
            else
            {
                var response = await _poAttributeValueRepository.GetAsync(predicate: x => x.Id == poAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedPoAttributeValueResponse>(response);
            }
        }
    }
}

