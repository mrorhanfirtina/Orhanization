using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Create;

public class CreateReturnItmStockAttrValueCommand : IRequest<CreatedReturnItmStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItmStockAttrValues";

    public CreateReturnItmStockAttrValueDto ReturnItmStockAttrValue { get; set; }


    public class CreateReturnItmStockAttrValueCommandHandler : IRequestHandler<CreateReturnItmStockAttrValueCommand, CreatedReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnItmStockAttrValueCommandHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _mapper = mapper;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
        }

        public async Task<CreatedReturnItmStockAttrValueResponse> Handle(CreateReturnItmStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnItemIdExistence(request.ReturnItmStockAttrValue.ReturnItemId)
                .CheckStockAttributeIdExistence(request.ReturnItmStockAttrValue.StockAttributeId);

            ReturnItmStockAttrValue returnItmStockAttrValue = _mapper.Map<ReturnItmStockAttrValue>(request.ReturnItmStockAttrValue);
            returnItmStockAttrValue.Id = Guid.NewGuid();
            returnItmStockAttrValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedReturnItmStockAttrValueResponse>(await _returnItmStockAttrValueRepository.AddAsync(returnItmStockAttrValue));
        }
    }
}

