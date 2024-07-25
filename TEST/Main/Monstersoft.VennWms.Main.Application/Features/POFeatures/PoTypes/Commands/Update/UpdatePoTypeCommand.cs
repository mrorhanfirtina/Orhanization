using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Constants.PoTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;

public class UpdatePoTypeCommand : IRequest<UpdatedPoTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, PoTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetPoTypes"];

    public UpdatePoTypeDto PoType { get; set; }
    public PoTypesDetailLevel DetailLevel { get; set; }


    public class UpdatePoTypeCommandHandler : IRequestHandler<UpdatePoTypeCommand, UpdatedPoTypeResponse>
    {
        private readonly IPoTypeRepository _poTypeRepository;
        private readonly PoTypeBusinessRules _poTypeBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePoTypeCommandHandler(IPoTypeRepository poTypeRepository, PoTypeBusinessRules poTypeBusinessRules, IMapper mapper)
        {
            _poTypeRepository = poTypeRepository;
            _poTypeBusinessRules = poTypeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPoTypeResponse> Handle(UpdatePoTypeCommand request, CancellationToken cancellationToken)
        {
            _poTypeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.PoType.Id);

            PoType? currentPoType = await _poTypeRepository.GetAsync(predicate: x => x.Id == request.PoType.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            PoType? poType = _mapper.Map(request.PoType, currentPoType);
            poType.UpdatedDate = DateTime.Now;

            await _poTypeRepository.UpdateAsync(poType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _poTypeRepository.GetAsync(predicate: x => x.Id == poType.Id,
                include: x =>
                {
                    IQueryable<PoType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludePurchaseOrder)
                    {
                        query = query.Include(y => y.PurchaseOrders);
                    }

                    var includableQuery = query as IIncludableQueryable<PoType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedPoTypeResponse>(response);
            }
            else
            {
                var response = await _poTypeRepository.GetAsync(predicate: x => x.Id == poType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedPoTypeResponse>(response);
            }
        }
    }

}
