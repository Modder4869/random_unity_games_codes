using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaTestSettingData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public int Score { get; set; }
    [Key(3)]
    public int[] Unit { get; set; }
    [Key(4)]
    public int SpellGroup { get; set; }
    [Key(5)]
    public string AuthId { get; set; }
}
