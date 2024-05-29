using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants.ProductDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Update;

public class UpdateProductDepositorCommand : IRequest<UpdatedProductDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, ProductDepositorOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductDepositors";

    public UpdateProductDepositorDto ProductDepositor { get; set; }
    public ProductDepositorDetailLevel DetailLevel { get; set; }



    public class UpdateProductDepositorCommandHandler : IRequestHandler<UpdateProductDepositorCommand, UpdatedProductDepositorResponse>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateProductDepositorCommandHandler(IProductDepositorRepository productDepositorRepository, ProductDepositorBusinessRules productDepositorBusinessRules, IMapper mapper)
        {
            _productDepositorRepository = productDepositorRepository;
            _productDepositorBusinessRules = productDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedProductDepositorResponse> Handle(UpdateProductDepositorCommand request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ProductDepositor.Id)
            .CheckDepositorIdExistence(request.ProductDepositor.DepositorId)
            .CheckProductIdExistence(request.ProductDepositor.ProductId);

            ProductDepositor? currentProductDepositor = await _productDepositorRepository.GetAsync(predicate: x => x.Id == request.ProductDepositor.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ProductDepositor? productDepositor = _mapper.Map(request.ProductDepositor, currentProductDepositor);
            productDepositor.UpdatedDate = DateTime.Now;

            await _productDepositorRepository.UpdateAsync(productDepositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _productDepositorRepository.GetAsync(predicate: x => x.Id == productDepositor.Id,
                include: x =>
                {
                    IQueryable<ProductDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }

                    if (detailLevel.IncludeProduct)
                    {
                        query = query.Include(y => y.Product);
                    }

                    var includableQuery = query as IIncludableQueryable<ProductDepositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductDepositorResponse>(response);
            }
            else
            {
                var response = await _productDepositorRepository.GetAsync(predicate: x => x.Id == productDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedProductDepositorResponse>(response);
            }
        }
    }
}


