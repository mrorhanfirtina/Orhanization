using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants.BarcodesOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;

public class DeleteBarcodeCommand : IRequest<DeletedBarcodeResponse>, ITransactionalRequest, ICacheRemoveRequest, 
    ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetBarcodes"];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];

    public Guid Id { get; set; }


    public class DeleteBarcodeCommandHandler : IRequestHandler<DeleteBarcodeCommand, DeletedBarcodeResponse>
    {
        private readonly IBarcodeRepository _barcodeRepository;
        private readonly BarcodeBusinessRules _barcodeBusinessRules;

        public DeleteBarcodeCommandHandler(IBarcodeRepository barcodeRepository, BarcodeBusinessRules barcodeBusinessRules)
        {
            _barcodeRepository = barcodeRepository;
            _barcodeBusinessRules = barcodeBusinessRules;
        }

        public async Task<DeletedBarcodeResponse> Handle(DeleteBarcodeCommand request, CancellationToken cancellationToken)
        {
            _barcodeBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Barcode barcode = await _barcodeRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.BarcodeAreas).Include(y => y.BarcodePrinters),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _barcodeRepository.DeleteAsync(barcode);

            return new DeletedBarcodeResponse
            {
                Id = barcode.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BarcodeMessages.RequestExecutedSuccessfully
            };
        }
    }

}

