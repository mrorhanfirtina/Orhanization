using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Constants.ReturnAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Queries.GetById;

public class GetByIdReturnAttributeQuery : IRequest<GetByIdReturnAttributeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnAttributeQueryHandler : IRequestHandler<GetByIdReturnAttributeQuery, GetByIdReturnAttributeResponse>
    {
        private readonly IReturnAttributeRepository _returnAttributeRepository;
        private readonly ReturnAttributeBusinessRules _returnAttributeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnAttributeQueryHandler(IReturnAttributeRepository returnAttributeRepository, IMapper mapper, ReturnAttributeBusinessRules returnAttributeBusinessRules)
        {
            _returnAttributeRepository = returnAttributeRepository;
            _mapper = mapper;
            _returnAttributeBusinessRules = returnAttributeBusinessRules;
        }

        public async Task<GetByIdReturnAttributeResponse> Handle(GetByIdReturnAttributeQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnAttributeResponse>(await _returnAttributeRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
