using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Dtos.CreateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnTypes.Commands.Create;

public class CreateReturnTypeCommand : IRequest<CreatedReturnTypeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnTypes";

    public CreateReturnTypeDto ReturnType { get; set; }
    public ReturnTypesDetailLevel? DetailLevel { get; set; }


    public class CreateReturnTypeCommandHandler : IRequestHandler<CreateReturnTypeCommand, CreatedReturnTypeResponse>
    {
        private readonly IReturnTypeRepository _returnTypeRepository;
        private readonly IMapper _mapper;
        private readonly ReturnTypeBusinessRules _returnTypeBusinessRules;

        public CreateReturnTypeCommandHandler(IReturnTypeRepository returnTypeRepository, IMapper mapper, ReturnTypeBusinessRules returnTypeBusinessRules)
        {
            _returnTypeRepository = returnTypeRepository;
            _mapper = mapper;
            _returnTypeBusinessRules = returnTypeBusinessRules;
        }

        public async Task<CreatedReturnTypeResponse> Handle(CreateReturnTypeCommand request, CancellationToken cancellationToken)
        {
            _returnTypeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ReturnType.Code);

            ReturnType? returnTypeEntity = _mapper.Map<ReturnType>(request.ReturnType);

            returnTypeEntity.CreatedDate = DateTime.Now;
            returnTypeEntity.Id = Guid.NewGuid();
            returnTypeEntity.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            await _returnTypeRepository.AddAsync(returnTypeEntity);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _returnTypeRepository.GetAsync(predicate: x => x.Id == returnTypeEntity.Id,
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

                return _mapper.Map<CreatedReturnTypeResponse>(response);
            }
            else
            {
                var response = await _returnTypeRepository.GetAsync(predicate: x => x.Id == returnTypeEntity.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnTypeResponse>(response);
            }
        }
    }
}
