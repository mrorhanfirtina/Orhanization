using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailsExpensions
{
    public static string AsJson<TProblemDetail>(this TProblemDetail details) where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(details);
}
