﻿namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Queries.GetById;

public class GetByIdLocationResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid StorageSystemId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
