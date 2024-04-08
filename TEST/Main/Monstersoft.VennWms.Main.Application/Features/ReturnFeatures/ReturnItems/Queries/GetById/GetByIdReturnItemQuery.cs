using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants.ReturnItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;

public class GetByIdReturnItemQuery : IRequest<GetByIdReturnItemResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdReturnItemQueryHandler : IRequestHandler<GetByIdReturnItemQuery, GetByIdReturnItemResponse>
    {
        private readonly IReturnItemRepository _returnItemRepository;
        private readonly ReturnItemBusinessRules _returnItemBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItemQueryHandler(IReturnItemRepository returnItemRepository, IMapper mapper, ReturnItemBusinessRules returnItemBusinessRules)
        {
            _returnItemRepository = returnItemRepository;
            _mapper = mapper;
            _returnItemBusinessRules = returnItemBusinessRules;
        }

        public async Task<GetByIdReturnItemResponse> Handle(GetByIdReturnItemQuery request, CancellationToken cancellationToken)
        {
            _returnItemBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdReturnItemResponse>(await _returnItemRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(x => x.ReturnItemMemos).Include(x => x.ReturnItmStockAttrValues),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
