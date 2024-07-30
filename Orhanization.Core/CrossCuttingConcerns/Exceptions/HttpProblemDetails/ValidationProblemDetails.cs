﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Orhanization.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class ValidationProblemDetails : ProblemDetails
{
    public IEnumerable<ValidationExceptionModel> Errors { get; set; }
    public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
    {
        Title = "Validation Error(s)";
        Detail = "One or more validation errors occured!";
        Errors = errors;
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/problems/validation";
    }
}
