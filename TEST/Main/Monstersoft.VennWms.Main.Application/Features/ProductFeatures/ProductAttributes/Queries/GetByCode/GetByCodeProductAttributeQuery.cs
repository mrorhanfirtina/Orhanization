using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Constants.ProductAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetByCode;

public class GetByCodeProductAttributeQuery : IRequest<GetByCodeProductAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeProductAttributeQueryHandler : IRequestHandler<GetByCodeProductAttributeQuery, GetByCodeProductAttributeResponse>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeProductAttributeQueryHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper, ProductAttributeBusinessRules productAttributeBusinessRules)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
            _productAttributeBusinessRules = productAttributeBusinessRules;
        }

        public async Task<GetByCodeProductAttributeResponse> Handle(GetByCodeProductAttributeQuery request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeProductAttributeResponse>(await _productAttributeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
