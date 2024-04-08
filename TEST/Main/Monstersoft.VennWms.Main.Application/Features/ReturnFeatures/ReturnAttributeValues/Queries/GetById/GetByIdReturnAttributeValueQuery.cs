using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Queries.GetById;

public class GetByIdReturnAttributeValueQuery : IRequest<GetByIdReturnAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnAttributeValueQueryHandler : IRequestHandler<GetByIdReturnAttributeValueQuery, GetByIdReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnAttributeValueQueryHandler(IReturnAttributeValueRepository returnAttributeValueRepository, IMapper mapper, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _mapper = mapper;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
        }

        public async Task<GetByIdReturnAttributeValueResponse> Handle(GetByIdReturnAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnAttributeValueResponse>(await _returnAttributeValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

