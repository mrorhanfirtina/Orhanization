using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class ItemPackType : Entity<Guid>
{ 
    public Guid ItemUnitId { get; set; }
    public decimal? Length { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public int LenghtUnitId { get; set; }
    public decimal? Volume { get; set; }
    public int VolumeUnitId { get; set; }
    public decimal? DeadWeight { get; set; }
    public decimal? NetWeight { get; set; }
    public int WeightUnitId { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }
    public virtual Unit? LenghtUnit { get; set; }
    public virtual Unit? VolumeUnit { get; set; }
    public virtual Unit? WeightUnit { get; set; }

    public ItemPackType()
    {
    }

    public ItemPackType(Guid id, Guid itemUnitId, int lenghtUnitId, int volumeUnitId, int weightUnitId, decimal? length = 0, decimal? width = 0, decimal? height = 0,  decimal? volume = 0, decimal? deadWeight = 0, decimal? netWeight = 0) : this()
    {
        Id = id;
        ItemUnitId = itemUnitId;
        Length = length;
        Width = width;
        Height = height;
        LenghtUnitId = lenghtUnitId;
        Volume = volume;
        VolumeUnitId = volumeUnitId;
        DeadWeight = deadWeight;
        NetWeight = netWeight;
        WeightUnitId = weightUnitId;
    }
}
