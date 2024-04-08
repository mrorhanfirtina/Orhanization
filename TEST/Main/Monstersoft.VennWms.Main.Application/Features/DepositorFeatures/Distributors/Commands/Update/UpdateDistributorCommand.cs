using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;

public class UpdateDistributorCommand : IRequest<UpdatedDistributorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, DistributorOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetDisturbitors";

    public UpdateDistributorDto Disturbitor { get; set; }


    public class UpdateDisturbitorCommandHandler : IRequestHandler<UpdateDistributorCommand, UpdatedDistributorResponse>
    {
        private readonly IDistributorRepository _companyRepository;
        private readonly DistributorBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateDisturbitorCommandHandler(IDistributorRepository companyRepository, DistributorBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedDistributorResponse> Handle(UpdateDistributorCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.UpdateRequest()
                .CheckIdExistence(request.Disturbitor.Id)
                .CheckAddressIdExistence(request.Disturbitor.AddressId)
                .CheckCodeExistenceWhenUpdate(request.Disturbitor.Code, request.Disturbitor.Id);

            Distributor currentDisturbitor = await _companyRepository.GetAsync(predicate: x => x.Id == request.Disturbitor.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Distributor? disturbitor = _mapper.Map(request.Disturbitor, currentDisturbitor);
            disturbitor.UpdatedDate = DateTime.Now;
            disturbitor.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedDistributorResponse>(await _companyRepository.UpdateAsync(disturbitor));
        }
    }
}

