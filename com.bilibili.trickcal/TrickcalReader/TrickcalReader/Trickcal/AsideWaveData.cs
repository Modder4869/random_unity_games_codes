using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideWaveData : TableItem<TableData> {
    [Key(0)]
    public int StageInfoUid { get; set; }
    [Key(1)]
    public int WaveOrder { get; set; }
    [Key(2)]
    public int SpawnOrder { get; set; }
    [Key(3)]
    public int MonsterLevel { get; set; }
    [Key(4)]
    public MonsterType WaveType { get; set; }
    [Key(5)]
    public int[] MonsterUid { get; set; }
    [Key(6)]
    public int[] SpawnRate { get; set; }
    [Key(7)]
    public int MaxSpawnCount { get; set; }
    [Key(8)]
    public float SpawnInterval { get; set; }
    [Key(9)]
    public string SpawnPosZ { get; set; }
}
