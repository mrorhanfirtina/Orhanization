using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants.ReturnMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetById;

public class GetByIdReturnMemoQuery : IRequest<GetByIdReturnMemoResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public ReturnMemosDetailLevel? DetailLevel { get; set; }

    public class GetByIdReturnMemoQueryHandler : IRequestHandler<GetByIdReturnMemoQuery, GetByIdReturnMemoResponse>
    {
        private readonly IReturnMemoRepository _returnMemoRepository;
        private readonly ReturnMemoBusinessRules _returnMemoBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdReturnMemoQueryHandler(IReturnMemoRepository returnMemoRepository, IMapper mapper, ReturnMemoBusinessRules returnMemoBusinessRules)
        {
            _returnMemoRepository = returnMemoRepository;
            _mapper = mapper;
            _returnMemoBusinessRules = returnMemoBusinessRules;
        }

        public async Task<GetByIdReturnMemoResponse> Handle(GetByIdReturnMemoQuery request, CancellationToken cancellationToken)
        {
            _returnMemoBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdReturnMemoResponse>(await _returnMemoRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ReturnMemo> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnMemo, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdReturnMemoResponse>(await _returnMemoRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
