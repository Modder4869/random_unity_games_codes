using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaAppearMonsterGroupData : TableItem<TableData> {
    [Key(0)]
    public int AppearMonsterGroupUid { get; set; }
    [Key(1)]
    public string MonsterUid { get; set; }
    [Key(2)]
    public int SpawnCount { get; set; }
    [Key(3)]
    public int SpawnOrder { get; set; }
    [Key(4)]
    public int MonsterLevel { get; set; }
}
