using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Constants.ProductStockAttributeOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetById;

public class GetByIdProductStockAttributeQuery : IRequest<GetByIdProductStockAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductStockAttributeQueryHandler : IRequestHandler<GetByIdProductStockAttributeQuery, GetByIdProductStockAttributeResponse>
    {
        private readonly IProductStockAttributeRepository _productStockAttributeRepository;
        private readonly ProductStockAttributeBusinessRules _productStockAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductStockAttributeQueryHandler(IProductStockAttributeRepository productStockAttributeRepository, IMapper mapper, ProductStockAttributeBusinessRules productStockAttributeBusinessRules)
        {
            _productStockAttributeRepository = productStockAttributeRepository;
            _mapper = mapper;
            _productStockAttributeBusinessRules = productStockAttributeBusinessRules;
        }

        public async Task<GetByIdProductStockAttributeResponse> Handle(GetByIdProductStockAttributeQuery request, CancellationToken cancellationToken)
        {
            _productStockAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductStockAttributeResponse>(await _productStockAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

