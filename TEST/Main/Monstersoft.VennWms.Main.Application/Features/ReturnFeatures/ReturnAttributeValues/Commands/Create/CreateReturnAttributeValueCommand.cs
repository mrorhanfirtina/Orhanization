using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants.ReturnAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;

public class CreateReturnAttributeValueCommand : IRequest<CreatedReturnAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetReturnAttributeValues"];


    public CreateReturnAttributeValueDto ReturnAttributeValue { get; set; }
    public ReturnAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class CreateReturnAttributeValueCommandHandler : IRequestHandler<CreateReturnAttributeValueCommand, CreatedReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateReturnAttributeValueCommandHandler(IReturnAttributeValueRepository returnAttributeValueRepository, IMapper mapper, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _mapper = mapper;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
        }

        public async Task<CreatedReturnAttributeValueResponse> Handle(CreateReturnAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckReturnAttributeIdExistence(request.ReturnAttributeValue.ReturnAttributeId)
                .CheckReturnIdExistence(request.ReturnAttributeValue.ReturnId);

            ReturnAttributeValue returnAttributeValue = _mapper.Map<ReturnAttributeValue>(request.ReturnAttributeValue);
            returnAttributeValue.Id = Guid.NewGuid();
            returnAttributeValue.CreatedDate = DateTime.Now;

            await _returnAttributeValueRepository.AddAsync(returnAttributeValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == returnAttributeValue.Id,
                include: x =>
                {
                    IQueryable<ReturnAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeReturn)
                    {
                        query = query.Include(y => y.Return);
                    }

                    if (detailLevel.IncludeReturnAttribute)
                    {
                        query = query.Include(y => y.ReturnAttribute);

                        var returnAttributeDetailLevel = detailLevel.ReturnAttributeDetailLevel;

                        if (returnAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.ReturnAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ReturnAttributeValue, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnAttributeValueResponse>(response);
            }
            else
            {
                var response = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == returnAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedReturnAttributeValueResponse>(response);
            }
        }
    }

}

