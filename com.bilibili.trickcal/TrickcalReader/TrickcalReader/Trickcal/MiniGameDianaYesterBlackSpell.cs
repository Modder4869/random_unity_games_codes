using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniGameDianaYesterBlackSpell : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public string Key { get; set; }
    [Key(3)]
    public int GroupRatio { get; set; }
    [Key(5)]
    public int Interaction { get; set; }
    [Key(6)]
    public int ActivateTakenTime { get; set; }
}
