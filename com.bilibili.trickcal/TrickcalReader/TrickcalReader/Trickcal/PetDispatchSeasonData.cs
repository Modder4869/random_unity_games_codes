using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchSeasonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string DispatchSeasonName { get; set; }
    [Key(2)]
    public int DispatchTaskGroup { get; set; }
    [Key(3)]
    public string DispatchImage { get; set; }
    [Key(4)]
    public string SeasonEffectName { get; set; }
    [Key(5)]
    public string PrefabName { get; set; }
}
