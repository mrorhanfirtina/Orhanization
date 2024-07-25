using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants.ReturnTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Update;

public class UpdateReturnTypeCommand : IRequest<UpdatedReturnTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnTypeOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnTypes"];

    public UpdateReturnTypeDto ReturnType { get; set; }
    public ReturnTypesDetailLevel? DetailLevel { get; set; }


    public class UpdateReturnTypeCommandHandler : IRequestHandler<UpdateReturnTypeCommand, UpdatedReturnTypeResponse>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly IMapper _mapper;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;

        public UpdateReturnTypeCommandHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _mapper = mapper;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<UpdatedReturnTypeResponse> Handle(UpdateReturnTypeCommand request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.UpdateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckIdExistence(request.ReturnType.Id)
                .CheckCodeExistenceWhenUpdate(request.ReturnType.Code, Guid.Parse(request.UserRequestInfo.RequestUserLocalityId));

            ReturnType? currentReturnType = await _returnTypeRepository.GetAsync(predicate: x => x.Id == request.ReturnType.Id,
            withDeleted: false, enableTracking: true, cancellationToken: cancellationToken);

            ReturnType updatedReturnType = _mapper.Map(request.ReturnType, currentReturnType);

            await _returnTypeRepository.UpdateAsync(updatedReturnType);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _returnTypeRepository.GetAsync(predicate: x => x.Id == updatedReturnType.Id,
                include: x =>
                {
                    IQueryable<ReturnType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Returns);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnType, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnTypeResponse>(response);
            }
            else
            {
                var response = await _returnTypeRepository.GetAsync(predicate: x => x.Id == updatedReturnType.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnTypeResponse>(response);
            }
        }
    }
}
