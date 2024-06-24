using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants.StockPackTypeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Commands.Delete;

public class DeleteStockPackTypeCommand : IRequest<DeletedStockPackTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, StockPackTypeOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStockPackTypes";

    public Guid Id { get; set; }


    public class DeleteStockPackTypeCommandHandler : IRequestHandler<DeleteStockPackTypeCommand, DeletedStockPackTypeResponse>
    {
        private readonly IStockPackTypeRepository _stockPackTypeRepository;
        private readonly StockPackTypeBusinessRules _stockPackTypeBusinessRules;

        public DeleteStockPackTypeCommandHandler(IStockPackTypeRepository stockPackTypeRepository, StockPackTypeBusinessRules stockPackTypeBusinessRules)
        {
            _stockPackTypeRepository = stockPackTypeRepository;
            _stockPackTypeBusinessRules = stockPackTypeBusinessRules;
        }

        public async Task<DeletedStockPackTypeResponse> Handle(DeleteStockPackTypeCommand request, CancellationToken cancellationToken)
        {
            _stockPackTypeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            StockPackType stockPackType = await _stockPackTypeRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _stockPackTypeRepository.DeleteAsync(stockPackType);

            return new DeletedStockPackTypeResponse
            {
                Id = stockPackType.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = StockPackTypeMessages.RequestExecutedSuccessfully
            };
        }
    }
}

