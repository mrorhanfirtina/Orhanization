using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
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
    public string? CacheGroupKey => "GetTaskCodeFormats";

    public UpdateTaskCodeFormatDto TaskCodeFormat { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedTaskCodeFormatResponse>(await _taskCodeFormatRepository.UpdateAsync(taskCodeFormat));
        }
    }
}
