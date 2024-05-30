using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;

public class CreateProductDepositorCommand : IRequest<CreatedProductDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetProductDepositors";

    public CreateProductDepositorDto ProductDepositor { get; set; }
    public ProductDepositorsDetailLevel DetailLevel { get; set; }



    public class CreateProductDepositorCommandHandler : IRequestHandler<CreateProductDepositorCommand, CreatedProductDepositorResponse>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateProductDepositorCommandHandler(IProductDepositorRepository productDepositorRepository, IMapper mapper, ProductDepositorBusinessRules productDepositorBusinessRules)
        {
            _productDepositorRepository = productDepositorRepository;
            _mapper = mapper;
            _productDepositorBusinessRules = productDepositorBusinessRules;
        }

        public async Task<CreatedProductDepositorResponse> Handle(CreateProductDepositorCommand request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckDepositorIdExistence(request.ProductDepositor.DepositorId)
                .CheckProductIdExistence(request.ProductDepositor.ProductId);

            ProductDepositor productDepositor = _mapper.Map<ProductDepositor>(request.ProductDepositor);
            productDepositor.Id = Guid.NewGuid();
            productDepositor.CreatedDate = DateTime.Now;

            await _productDepositorRepository.AddAsync(productDepositor);

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

                return _mapper.Map<CreatedProductDepositorResponse>(response);
            }
            else
            {
                var response = await _productDepositorRepository.GetAsync(predicate: x => x.Id == productDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedProductDepositorResponse>(response);
            }
        }
    }

}


