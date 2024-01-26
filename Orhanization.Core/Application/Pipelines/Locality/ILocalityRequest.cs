using Orhanization.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orhanization.Core.Application.Pipelines.Locality;

public interface ILocalityRequest
{
    [JsonIgnore]
    public UserRequestInfo userRequestInfo { get; set; }
}
