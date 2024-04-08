using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Constants.ItemUnitOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;

public class GetByIdItemUnitQuery : IRequest<GetByIdItemUnitResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdItemUnitQueryHandler : IRequestHandler<GetByIdItemUnitQuery, GetByIdItemUnitResponse>
    {
        private readonly IItemUnitRepository _ıtemUnitRepository;
        private readonly ItemUnitBusinessRules _ıtemUnitBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdItemUnitQueryHandler(IItemUnitRepository ıtemUnitRepository, IMapper mapper, ItemUnitBusinessRules ıtemUnitBusinessRules)
        {
            _ıtemUnitRepository = ıtemUnitRepository;
            _mapper = mapper;
            _ıtemUnitBusinessRules = ıtemUnitBusinessRules;
        }

        public async Task<GetByIdItemUnitResponse> Handle(GetByIdItemUnitQuery request, CancellationToken cancellationToken)
        {
            _ıtemUnitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdItemUnitResponse>(await _ıtemUnitRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.ItemPackTypes),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
