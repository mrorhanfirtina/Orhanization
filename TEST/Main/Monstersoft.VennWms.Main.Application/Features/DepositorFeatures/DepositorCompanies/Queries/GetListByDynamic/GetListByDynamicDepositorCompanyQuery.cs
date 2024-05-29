using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetListByDynamic;

public class GetListByDynamicDepositorCompanyQuery : IRequest<GetListResponse<GetListByDynamicDepositorCompanyListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public DepositorCompanyDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicDepositorCompanyQueryHandler : IRequestHandler<GetListByDynamicDepositorCompanyQuery, GetListResponse<GetListByDynamicDepositorCompanyListItemDto>>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicDepositorCompanyQueryHandler(IDepositorCompanyRepository depositorCompanyRepository, IMapper mapper, DepositorCompanyBusinessRules depositorCompanyBusinessRules)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicDepositorCompanyListItemDto>> Handle(GetListByDynamicDepositorCompanyQuery request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<DepositorCompany> depositorCompanyList = await _depositorCompanyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<DepositorCompany> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }


                    var includableQuery = query as IIncludableQueryable<DepositorCompany, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicDepositorCompanyListItemDto>>(depositorCompanyList);
            }
            else
            {
                Paginate<DepositorCompany> depositorCompanyList = await _depositorCompanyRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicDepositorCompanyListItemDto>>(depositorCompanyList);
            }
        }
    }

}
