using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetById;

public class GetByIdTaskCodeFormatQuery : IRequest<GetByIdTaskCodeFormatResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public TaskCodeFormatsDetailLevel? DetailLevel { get; set; }


    public class GetByIdTaskCodeFormatQueryHandler : IRequestHandler<GetByIdTaskCodeFormatQuery, GetByIdTaskCodeFormatResponse>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdTaskCodeFormatQueryHandler(ITaskCodeFormatRepository taskCodeFormatRepository, IMapper mapper, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _mapper = mapper;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
        }

        public async Task<GetByIdTaskCodeFormatResponse> Handle(GetByIdTaskCodeFormatQuery request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdTaskCodeFormatResponse>(await _taskCodeFormatRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<TaskCodeFormat> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeTransactionType)
                    {
                        query = query.Include(y => y.TransactionType);
                    }

                    var includableQuery = query as IIncludableQueryable<TaskCodeFormat, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdTaskCodeFormatResponse>(await _taskCodeFormatRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
