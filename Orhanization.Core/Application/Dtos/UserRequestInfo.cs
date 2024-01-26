using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orhanization.Core.Application.Dtos;

public class UserRequestInfo : IDto
{
    public int RequestUserId { get; set; }
    public string RequestUserLocalityId { get; set; }

    public UserRequestInfo()
    {
        RequestUserId = -1;
        RequestUserLocalityId = string.Empty;
    }
}
