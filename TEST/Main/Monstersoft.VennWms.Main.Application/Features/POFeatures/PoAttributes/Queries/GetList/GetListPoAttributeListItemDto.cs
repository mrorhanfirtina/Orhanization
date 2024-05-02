﻿namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Queries.GetList;

public class GetListPoAttributeListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }


}
