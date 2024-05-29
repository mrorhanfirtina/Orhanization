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
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants.DepositorCompanyOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetById;

public class GetByIdDepositorCompanyQuery : IRequest<GetByIdDepositorCompanyResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public DepositorCompanyDetailLevel DetailLevel { get; set; }


    public class GetByIdDepositorCompanyQueryHandler : IRequestHandler<GetByIdDepositorCompanyQuery, GetByIdDepositorCompanyResponse>
    {
        private readonly IDepositorCompanyRepository _depositorCompanyRepository;
        private readonly DepositorCompanyBusinessRules _depositorCompanyBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdDepositorCompanyQueryHandler(IDepositorCompanyRepository depositorCompanyRepository, IMapper mapper, DepositorCompanyBusinessRules depositorCompanyBusinessRules)
        {
            _depositorCompanyRepository = depositorCompanyRepository;
            _mapper = mapper;
            _depositorCompanyBusinessRules = depositorCompanyBusinessRules;
        }

        public async Task<GetByIdDepositorCompanyResponse> Handle(GetByIdDepositorCompanyQuery request, CancellationToken cancellationToken)
        {
            _depositorCompanyBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdDepositorCompanyResponse>(await _depositorCompanyRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdDepositorCompanyResponse>(await _depositorCompanyRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }


        }

    }

}
