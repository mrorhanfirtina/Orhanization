using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants.ProductAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetById;

public class GetByIdProductAttributeValueQuery : IRequest<GetByIdProductAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductAttributeValueQueryHandler : IRequestHandler<GetByIdProductAttributeValueQuery, GetByIdProductAttributeValueResponse>
    {
        private readonly IProductAttributeValueRepository _productAttributeValueRepository;
        private readonly ProductAttributeValueBusinessRules _productAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductAttributeValueQueryHandler(IProductAttributeValueRepository productAttributeValueRepository, IMapper mapper, ProductAttributeValueBusinessRules productAttributeValueBusinessRules)
        {
            _productAttributeValueRepository = productAttributeValueRepository;
            _mapper = mapper;
            _productAttributeValueBusinessRules = productAttributeValueBusinessRules;
        }

        public async Task<GetByIdProductAttributeValueResponse> Handle(GetByIdProductAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _productAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductAttributeValueResponse>(await _productAttributeValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

