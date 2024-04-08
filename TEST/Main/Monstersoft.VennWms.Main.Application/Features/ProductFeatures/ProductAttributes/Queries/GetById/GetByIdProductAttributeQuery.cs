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


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetById;

public class GetByIdProductAttributeQuery : IRequest<GetByIdProductAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductAttributeQueryHandler : IRequestHandler<GetByIdProductAttributeQuery, GetByIdProductAttributeResponse>
    {
        private readonly IProductAttributeRepository _productAttributeRepository;
        private readonly ProductAttributeBusinessRules _productAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductAttributeQueryHandler(IProductAttributeRepository productAttributeRepository, IMapper mapper, ProductAttributeBusinessRules productAttributeBusinessRules)
        {
            _productAttributeRepository = productAttributeRepository;
            _mapper = mapper;
            _productAttributeBusinessRules = productAttributeBusinessRules;
        }

        public async Task<GetByIdProductAttributeResponse> Handle(GetByIdProductAttributeQuery request, CancellationToken cancellationToken)
        {
            _productAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductAttributeResponse>(await _productAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
