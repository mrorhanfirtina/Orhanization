using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants.ReturnItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetById;

public class GetByIdReturnItemMemoQuery : IRequest<GetByIdReturnItemMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnItemMemosDetailLevel? DetailLevel { get; set; }


    public class GetByIdReturnItemMemoQueryHandler : IRequestHandler<GetByIdReturnItemMemoQuery, GetByIdReturnItemMemoResponse>
    {
        private readonly IReturnItemMemoRepository _returnItemMemoRepository;
        private readonly ReturnItemMemoBusinessRules _returnItemMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnItemMemoQueryHandler(IReturnItemMemoRepository returnItemMemoRepository, IMapper mapper, ReturnItemMemoBusinessRules returnItemMemoBusinessRules)
        {
            _returnItemMemoRepository = returnItemMemoRepository;
            _mapper = mapper;
            _returnItemMemoBusinessRules = returnItemMemoBusinessRules;
        }

        public async Task<GetByIdReturnItemMemoResponse> Handle(GetByIdReturnItemMemoQuery request, CancellationToken cancellationToken)
        {
            _returnItemMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnItemMemoResponse>(await _returnItemMemoRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ReturnItemMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturnItem)
                    {
                        query = query.Include(y => y.ReturnItem);

                        var returnItemDetailLevel = detailLevel.ReturnItemDetailLevel;

                        if (returnItemDetailLevel.IncludeReturn)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Return);
                        }

                        if (returnItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.ReturnItem).ThenInclude(y => y.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnItemMemo, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnItemMemoResponse>(await _returnItemMemoRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}

