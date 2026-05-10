using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEMinionSpawnData {
    [Key(1)]
    public int UnitUid { get; set; }
    [Key(2)]
    public TeamType Team { get; set; }
    [Key(3)]
    public int InitId { get; set; }
    [Key(4)]
    public float PosX { get; set; }
    [Key(5)]
    public float PosY { get; set; }
    [Key(6)]
    public float PosZ { get; set; }
    [Key(7)]
    public string MasterWWEUid { get; set; }
}
