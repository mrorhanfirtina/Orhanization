using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class InternalServerProblemDetails : ProblemDetails
{
    public string innerException { get; set; }
    public InternalServerProblemDetails(string detail, string? innerDetail = null)
    {
        Title = "Internal Server Error";
        Detail = "Internal Server Error";
        innerException = innerDetail;
        Status = StatusCodes.Status500InternalServerError;
        Type = "https://example.com/problems/internal";
    }
}
