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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Queries.GetById;

public class GetByIdReturnTypeQuery : IRequest<GetByIdReturnTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnTypeQueryHandler : IRequestHandler<GetByIdReturnTypeQuery, GetByIdReturnTypeResponse>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnTypeQueryHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _mapper = mapper;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<GetByIdReturnTypeResponse> Handle(GetByIdReturnTypeQuery request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnTypeResponse>(await _returnTypeRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.Returns),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
