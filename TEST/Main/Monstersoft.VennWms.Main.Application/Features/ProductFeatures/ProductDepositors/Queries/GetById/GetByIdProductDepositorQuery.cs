using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Constants.ProductDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors;

public class GetByIdProductDepositorQuery : IRequest<GetByIdProductDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdProductDepositorQueryHandler : IRequestHandler<GetByIdProductDepositorQuery, GetByIdProductDepositorResponse>
    {
        private readonly IProductDepositorRepository _productDepositorRepository;
        private readonly ProductDepositorBusinessRules _productDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdProductDepositorQueryHandler(IProductDepositorRepository productDepositorRepository, IMapper mapper, ProductDepositorBusinessRules productDepositorBusinessRules)
        {
            _productDepositorRepository = productDepositorRepository;
            _mapper = mapper;
            _productDepositorBusinessRules = productDepositorBusinessRules;
        }

        public async Task<GetByIdProductDepositorResponse> Handle(GetByIdProductDepositorQuery request, CancellationToken cancellationToken)
        {
            _productDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdProductDepositorResponse>(await _productDepositorRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}


