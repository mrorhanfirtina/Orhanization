using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;

public class UpdateTaskCodeFormatCommand : IRequest<UpdatedTaskCodeFormatResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TaskCodeFormatOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskCodeFormats"];

    public UpdateTaskCodeFormatDto TaskCodeFormat { get; set; }
    public TaskCodeFormatsDetailLevel? DetailLevel { get; set; }


    public class UpdateTaskCodeFormatCommandHandler : IRequestHandler<UpdateTaskCodeFormatCommand, UpdatedTaskCodeFormatResponse>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;
        private readonly IMapper _mapper;

        public UpdateTaskCodeFormatCommandHandler(ITaskCodeFormatRepository taskCodeFormatRepository, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules, IMapper mapper)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedTaskCodeFormatResponse> Handle(UpdateTaskCodeFormatCommand request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.TaskCodeFormat.Id)
            .CheckCodeExistenceWhenUpdate(request.TaskCodeFormat.Code, request.TaskCodeFormat.Id)
            .CheckTransactionTypeIdExistence(request.TaskCodeFormat.TransactionTypeId);

            TaskCodeFormat? currentTaskCodeFormat = await _taskCodeFormatRepository.GetAsync(predicate: x => x.Id == request.TaskCodeFormat.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            TaskCodeFormat? taskCodeFormat = _mapper.Map(request.TaskCodeFormat, currentTaskCodeFormat);
            taskCodeFormat.UpdatedDate = DateTime.Now;

            await _taskCodeFormatRepository.UpdateAsync(taskCodeFormat);

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

                return _mapper.Map<UpdatedTaskCodeFormatResponse>(response);
            }
            else
            {
                var response = await _taskCodeFormatRepository.GetAsync(predicate: x => x.Id == taskCodeFormat.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedTaskCodeFormatResponse>(response);
            }
        }
    }
}
