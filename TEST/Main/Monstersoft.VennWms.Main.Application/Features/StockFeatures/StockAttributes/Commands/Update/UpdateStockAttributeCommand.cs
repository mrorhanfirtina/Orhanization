using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Constants.StockAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Commands.Update;

public class UpdateStockAttributeCommand : IRequest<UpdatedStockAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StockAttributeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockAttributes";

    public UpdateStockAttributeDto StockAttribute { get; set; }
    public StockAttributesDetailLevel? DetailLevel { get; set; }


    public class UpdateStockAttributeCommandHandler : IRequestHandler<UpdateStockAttributeCommand, UpdatedStockAttributeResponse>
    {
        private readonly IStockAttributeRepository _stockAttributeRepository;
        private readonly StockAttributeBusinessRules _stockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStockAttributeCommandHandler(IStockAttributeRepository stockAttributeRepository, StockAttributeBusinessRules stockAttributeBusinessRules, IMapper mapper)
        {
            _stockAttributeRepository = stockAttributeRepository;
            _stockAttributeBusinessRules = stockAttributeBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStockAttributeResponse> Handle(UpdateStockAttributeCommand request, CancellationToken cancellationToken)
        {
            _stockAttributeBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StockAttribute.Id)
            .CheckAttributeInputTypeIdExistence(request.StockAttribute.AttributeInputTypeId)
            .CheckCodeExistenceWhenUpdate(request.StockAttribute.Code, request.StockAttribute.Id);

            StockAttribute? currentStockAttribute = await _stockAttributeRepository.GetAsync(predicate: x => x.Id == request.StockAttribute.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StockAttribute? stockAttribute = _mapper.Map(request.StockAttribute, currentStockAttribute);
            stockAttribute.UpdatedDate = DateTime.Now;

            await _stockAttributeRepository.UpdateAsync(stockAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _stockAttributeRepository.GetAsync(predicate: x => x.Id == stockAttribute.Id,
                include: x =>
                {
                    IQueryable<StockAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    var includableQuery = query as IIncludableQueryable<StockAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockAttributeResponse>(response);
            }
            else
            {
                var response = await _stockAttributeRepository.GetAsync(predicate: x => x.Id == stockAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedStockAttributeResponse>(response);
            }
        }
    }
}
