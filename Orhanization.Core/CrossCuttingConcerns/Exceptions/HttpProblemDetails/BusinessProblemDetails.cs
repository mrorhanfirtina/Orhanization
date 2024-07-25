using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class BusinessProblemDetails : ProblemDetails
{
    public string HelpLink { get; set; }
    public BusinessProblemDetails(string detail, string helpLink)
    {
        Title = "Business Rule Violation";
        Detail = detail;
        Status = StatusCodes.Status404NotFound;
        Type = "Business Rule";
        HelpLink = helpLink;
    }
}
