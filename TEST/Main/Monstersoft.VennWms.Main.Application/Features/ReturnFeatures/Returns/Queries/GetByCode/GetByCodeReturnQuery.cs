using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Queries.GetByCode;

public class GetByCodeReturnQuery : IRequest<GetByCodeReturnResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeReturnQueryHandler : IRequestHandler<GetByCodeReturnQuery, GetByCodeReturnResponse>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly ReturnBusinessRules _returnBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReturnQueryHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<GetByCodeReturnResponse> Handle(GetByCodeReturnQuery request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReturnResponse>(await _returnRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Customer).Include(x => x.ReturnMemos).Include(x => x.ReturnAttributeValues)
            .Include(x => x.ReturnItems).ThenInclude(ri => ri.ReturnItemMemos)
            .Include(x => x.ReturnItems).ThenInclude(ri => ri.ReturnItmStockAttrValues),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
