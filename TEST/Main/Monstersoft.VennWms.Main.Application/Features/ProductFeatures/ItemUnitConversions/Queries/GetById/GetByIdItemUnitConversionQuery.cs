using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants.ItemUnitConversionOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Queries.GetById;

public class GetByIdItemUnitConversionQuery : IRequest<GetByIdItemUnitConversionResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdItemUnitConversionQueryHandler : IRequestHandler<GetByIdItemUnitConversionQuery, GetByIdItemUnitConversionResponse>
    {
        private readonly IItemUnitConversionRepository _ıtemUnitConversionRepository;
        private readonly ItemUnitConversionBusinessRules _ıtemUnitConversionBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemUnitConversionQueryHandler(IItemUnitConversionRepository ıtemUnitConversionRepository, IMapper mapper, ItemUnitConversionBusinessRules ıtemUnitConversionBusinessRules)
        {
            _ıtemUnitConversionRepository = ıtemUnitConversionRepository;
            _mapper = mapper;
            _ıtemUnitConversionBusinessRules = ıtemUnitConversionBusinessRules;
        }

        public async Task<GetByIdItemUnitConversionResponse> Handle(GetByIdItemUnitConversionQuery request, CancellationToken cancellationToken)
        {
            _ıtemUnitConversionBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdItemUnitConversionResponse>(await _ıtemUnitConversionRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

