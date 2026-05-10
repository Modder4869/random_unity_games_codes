using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaTestSpellSettingData : TableItem<TableData> {
    [Key(0)]
    public int SpellGroupUid { get; set; }
    [Key(1)]
    public int SpellUid { get; set; }
    [Key(2)]
    public int Count { get; set; }
    [Key(3)]
    public short Level { get; set; }
}
