using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants.ReturnItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetById;

public class GetByIdReturnItmStockAttrValueQuery : IRequest<GetByIdReturnItmStockAttrValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnItmStockAttrValueQueryHandler : IRequestHandler<GetByIdReturnItmStockAttrValueQuery, GetByIdReturnItmStockAttrValueResponse>
    {
        private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
        private readonly ReturnItmStockAttrValueBusinessRules _returnItmStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItmStockAttrValueQueryHandler(IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IMapper mapper, ReturnItmStockAttrValueBusinessRules returnItmStockAttrValueBusinessRules)
        {
            _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
            _mapper = mapper;
            _returnItmStockAttrValueBusinessRules = returnItmStockAttrValueBusinessRules;
        }

        public async Task<GetByIdReturnItmStockAttrValueResponse> Handle(GetByIdReturnItmStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _returnItmStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnItmStockAttrValueResponse>(await _returnItmStockAttrValueRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

