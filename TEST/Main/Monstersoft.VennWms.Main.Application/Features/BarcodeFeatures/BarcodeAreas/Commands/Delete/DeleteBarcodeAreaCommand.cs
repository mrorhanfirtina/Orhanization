using MediatR;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants.BarcodeAreaOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Delete;

public class DeleteBarcodeAreaCommand : IRequest<DeletedBarcodeAreaResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, BarcodeAreaOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBarcodes"];

    public Guid Id { get; set; }


    public class DeleteBarcodeAreaCommandHandler : IRequestHandler<DeleteBarcodeAreaCommand, DeletedBarcodeAreaResponse>
    {
        private readonly IBarcodeAreaRepository _barcodeAreaRepository;
        private readonly BarcodeAreaBusinessRules _barcodeAreaBusinessRules;

        public DeleteBarcodeAreaCommandHandler(IBarcodeAreaRepository barcodeAreaRepository, BarcodeAreaBusinessRules barcodeAreaBusinessRules)
        {
            _barcodeAreaRepository = barcodeAreaRepository;
            _barcodeAreaBusinessRules = barcodeAreaBusinessRules;
        }

        public async Task<DeletedBarcodeAreaResponse> Handle(DeleteBarcodeAreaCommand request, CancellationToken cancellationToken)
        {
            _barcodeAreaBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            BarcodeArea barcodeArea = await _barcodeAreaRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _barcodeAreaRepository.DeleteAsync(barcodeArea);

            return new DeletedBarcodeAreaResponse
            {
                Id = barcodeArea.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BarcodeAreaMessages.RequestExecutedSuccessfully
            };
        }
    }
}



