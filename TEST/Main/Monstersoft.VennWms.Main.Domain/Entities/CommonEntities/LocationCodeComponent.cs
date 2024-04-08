using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class LocationCodeComponent : Entity<int>
{
    public string Description { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public string FieldCode { get; set; }

    public LocationCodeComponent()
    {
    }

    public LocationCodeComponent(int id, string description, string tableName, string fieldName, string fieldCode) : this()
    {
        Id = id;
        Description = description;
        TableName = tableName;
        FieldName = fieldName;
        FieldCode = fieldCode;
    }
}
