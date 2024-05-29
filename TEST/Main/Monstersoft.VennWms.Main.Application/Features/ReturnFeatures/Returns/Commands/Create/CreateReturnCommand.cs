using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Create;

public class CreateReturnCommand : IRequest<CreatedReturnResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturns";

    public CreateReturnDto Return { get; set; }


    public class CreateReturnCommandHandler : IRequestHandler<CreateReturnCommand, CreatedReturnResponse>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;
        private readonly ReturnBusinessRules _returnBusinessRules;

        public CreateReturnCommandHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<CreatedReturnResponse> Handle(CreateReturnCommand request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            Return? returnEntity = _mapper.Map<Return>(request.Return);

            returnEntity.CreatedDate = DateTime.Now;
            returnEntity.Id = Guid.NewGuid();
            returnEntity.DepositorCompanyId = Guid.Parse(request.UserRequestInfo!.RequestUserLocalityId);

            returnEntity.ReturnMemos?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            returnEntity.ReturnAttributeValues?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;
            });

            returnEntity.ReturnItems?.ToList().ForEach(x =>
            {
                x.CreatedDate = DateTime.Now;

                x.ReturnItemMemos?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
                x.ReturnItmStockAttrValues?.ToList().ForEach(y => { y.CreatedDate = DateTime.Now; });
            });

            return _mapper.Map<CreatedReturnResponse>(await _returnRepository.AddAsync(returnEntity));
       
        }
    }
}
