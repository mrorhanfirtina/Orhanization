using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants.ReturnOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Commands.Update;

public class UpdateReturnCommand : IRequest<UpdatedReturnResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ReturnOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetReturns";

    public UpdateReturnDto Return { get; set; }


    public class UpdateReturnCommandHandler : IRequestHandler<UpdateReturnCommand, UpdatedReturnResponse>
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;
        private readonly ReturnBusinessRules _returnBusinessRules;

        public UpdateReturnCommandHandler(IReturnRepository returnRepository, IMapper mapper, ReturnBusinessRules returnBusinessRules)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
            _returnBusinessRules = returnBusinessRules;
        }

        public async Task<UpdatedReturnResponse> Handle(UpdateReturnCommand request, CancellationToken cancellationToken)
        {
            _returnBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Return.Id);

            Return? currentReturn = await _returnRepository.GetAsync(predicate: x => x.Id == request.Return.Id,
            include: x => x.Include(y => y.ReturnAttributeValues)
                            .Include(y => y.ReturnMemos)
                            .Include(y => y.ReturnItems)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItemMemos)
                            .Include(y => y.ReturnItems).ThenInclude(z => z.ReturnItmStockAttrValues),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Return? returnEntity = _mapper.Map(request.Return, currentReturn);
            returnEntity.UpdatedDate = DateTime.Now;

            returnEntity.ReturnAttributeValues?.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = returnEntity.CreatedDate;
            });

            returnEntity.ReturnMemos?.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = returnEntity.CreatedDate;
            });

            returnEntity.ReturnItems?.ToList().ForEach(x =>
            {
                x.UpdatedDate = DateTime.Now;
                x.CreatedDate = returnEntity.CreatedDate;

                x.ReturnItemMemos?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; y.CreatedDate = returnEntity.CreatedDate; });
                x.ReturnItmStockAttrValues?.ToList().ForEach(y => { y.UpdatedDate = DateTime.Now; y.CreatedDate = returnEntity.CreatedDate; });
            });

            return _mapper.Map<UpdatedReturnResponse>(await _returnRepository.UpdateAsync(returnEntity));
        }
    }
}
