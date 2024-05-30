using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Update;

public class UpdateReturnAttributeValueCommand : IRequest<UpdatedReturnAttributeValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnAttributeValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturnAttributeValues";

    public UpdateReturnAttributeValueDto ReturnAttributeValue { get; set; }
    public ReturnAttributeValuesDetailLevel? DetailLevel { get; set; }


    public class UpdateReturnAttributeValueCommandHandler : IRequestHandler<UpdateReturnAttributeValueCommand, UpdatedReturnAttributeValueResponse>
    {
        private readonly IReturnAttributeValueRepository _returnAttributeValueRepository;
        private readonly ReturnAttributeValueBusinessRules _returnAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateReturnAttributeValueCommandHandler(IReturnAttributeValueRepository returnAttributeValueRepository, ReturnAttributeValueBusinessRules returnAttributeValueBusinessRules, IMapper mapper)
        {
            _returnAttributeValueRepository = returnAttributeValueRepository;
            _returnAttributeValueBusinessRules = returnAttributeValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedReturnAttributeValueResponse> Handle(UpdateReturnAttributeValueCommand request, CancellationToken cancellationToken)
        {
            _returnAttributeValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ReturnAttributeValue.Id)
            .CheckReturnAttributeIdExistence(request.ReturnAttributeValue.ReturnAttributeId)
            .CheckReturnIdExistence(request.ReturnAttributeValue.ReturnId);

            ReturnAttributeValue? currentReturnAttributeValue = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == request.ReturnAttributeValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ReturnAttributeValue? returnAttributeValue = _mapper.Map(request.ReturnAttributeValue, currentReturnAttributeValue);
            returnAttributeValue.UpdatedDate = DateTime.Now;

            await _returnAttributeValueRepository.UpdateAsync(returnAttributeValue);

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

                return _mapper.Map<UpdatedReturnAttributeValueResponse>(response);
            }
            else
            {
                var response = await _returnAttributeValueRepository.GetAsync(predicate: x => x.Id == returnAttributeValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedReturnAttributeValueResponse>(response);
            }
        }
    }
}

