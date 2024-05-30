using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants.PoAttributeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Create;

public class CreatePoAttributeCommand : IRequest<CreatedPoAttributeResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPoAttributes";

    public CreatePoAttributeDto PoAttribute { get; set; }
    public PoAttributesDetailLevel DetailLevel { get; set; }


    public class CreatePoAttributeCommandHandler : IRequestHandler<CreatePoAttributeCommand, CreatedPoAttributeResponse>
    {
        private readonly IPoAttributeRepository _poAttributeRepository;
        private readonly PoAttributeBusinessRules _poAttributeBusinessRules;
        private readonly IMapper _mapper;

        public CreatePoAttributeCommandHandler(IPoAttributeRepository poAttributeRepository, IMapper mapper, PoAttributeBusinessRules poAttributeBusinessRules)
        {
            _poAttributeRepository = poAttributeRepository;
            _mapper = mapper;
            _poAttributeBusinessRules = poAttributeBusinessRules;
        }

        public async Task<CreatedPoAttributeResponse> Handle(CreatePoAttributeCommand request, CancellationToken cancellationToken)
        {
            _poAttributeBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.PoAttribute.Code)
                .CheckAttributeInputTypeIdExistence(request.PoAttribute.AttributeInputTypeId);

            PoAttribute poAttribute = _mapper.Map<PoAttribute>(request.PoAttribute);
            poAttribute.Id = Guid.NewGuid();
            poAttribute.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            poAttribute.CreatedDate = DateTime.Now;

            await _poAttributeRepository.AddAsync(poAttribute);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _poAttributeRepository.GetAsync(predicate: x => x.Id == poAttribute.Id,
                include: x =>
                {
                    IQueryable<PoAttribute> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAttributeInputType)
                    {
                        query = query.Include(y => y.AttributeInputType);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<PoAttribute, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPoAttributeResponse>(response);
            }
            else
            {
                var response = await _poAttributeRepository.GetAsync(predicate: x => x.Id == poAttribute.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPoAttributeResponse>(response);
            }
        }
    }
}

