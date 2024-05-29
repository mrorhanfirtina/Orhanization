using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;

public class CreateReturnItemCommand : IRequest<CreatedReturnItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnItems";

    public CreateReturnItemDto ReturnItem { get; set; }


    public class CreateReturnItemCommandHandler : IRequestHandler<CreateReturnItemCommand, CreatedReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly IMapper _mapper;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;

        public CreateReturnItemCommandHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _mapper = mapper;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<CreatedReturnItemResponse> Handle(CreateReturnItemCommand request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            ReturnItem? returnItem = _mapper.Map<ReturnItem>(request.ReturnItem);

            returnItem.CreatedDate = DateTime.Now;

            returnItem.ReturnItemMemos?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });
            returnItem.ReturnItmStockAttrValues?.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            return _mapper.Map<CreatedReturnItemResponse>(await _returnItemRepository.AddAsync(returnItem));
        }
    }
}
