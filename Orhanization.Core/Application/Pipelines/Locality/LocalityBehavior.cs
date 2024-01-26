using MediatR;
using Microsoft.AspNetCore.Http;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Security.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.Application.Pipelines.Locality;

public class LocalityBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>, ILocalityRequest
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public LocalityBehavior(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        request.userRequestInfo.RequestUserId = _httpContextAccessor.HttpContext.User.GetUserId();
        request.userRequestInfo.RequestUserLocalityId = _httpContextAccessor.HttpContext.User.GetUserLocalityId();

        TResponse response = await next();
        return response;
    }
}
