using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Create;

public class CreateTaskCodeFormatCommand : IRequest<CreatedTaskCodeFormatResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskCodeFormats"];


    public CreateTaskCodeFormatDto TaskCodeFormat { get; set; }
    public TaskCodeFormatsDetailLevel? DetailLevel { get; set; }


    public class CreateTaskCodeFormatCommandHandler : IRequestHandler<CreateTaskCodeFormatCommand, CreatedTaskCodeFormatResponse>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;
        private readonly IMapper _mapper;

        public CreateTaskCodeFormatCommandHandler(ITaskCodeFormatRepository taskCodeFormatRepository, IMapper mapper, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _mapper = mapper;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
        }

        public async Task<CreatedTaskCodeFormatResponse> Handle(CreateTaskCodeFormatCommand request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.TaskCodeFormat.Code)
                .CheckTransactionTypeIdExistence(request.TaskCodeFormat.TransactionTypeId);

            TaskCodeFormat taskCodeFormat = _mapper.Map<TaskCodeFormat>(request.TaskCodeFormat);
            taskCodeFormat.Id = Guid.NewGuid();
            taskCodeFormat.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            taskCodeFormat.CreatedDate = DateTime.Now;

            await _taskCodeFormatRepository.AddAsync(taskCodeFormat);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _taskCodeFormatRepository.GetAsync(predicate: x => x.Id == taskCodeFormat.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTaskCodeFormatResponse>(response);
            }
            else
            {
                var response = await _taskCodeFormatRepository.GetAsync(predicate: x => x.Id == taskCodeFormat.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTaskCodeFormatResponse>(response);
            }
        }
    }
}
