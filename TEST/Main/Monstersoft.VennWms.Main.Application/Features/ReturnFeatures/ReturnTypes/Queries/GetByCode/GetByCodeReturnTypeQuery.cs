using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants.ReturnTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetByCode;

public class GetByCodeReturnTypeQuery : IRequest<GetByCodeReturnTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeReturnTypeQueryHandler : IRequestHandler<GetByCodeReturnTypeQuery, GetByCodeReturnTypeResponse>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReturnTypeQueryHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _mapper = mapper;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<GetByCodeReturnTypeResponse> Handle(GetByCodeReturnTypeQuery request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReturnTypeResponse>(await _returnTypeRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(x => x.Returns),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
