using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.Extensions;

public static class ProblemDetailsExpensions
{
    public static string AsJson<TProblemDetail>(this TProblemDetail details) where TProblemDetail : ProblemDetails => JsonSerializer.Serialize(details);
}
