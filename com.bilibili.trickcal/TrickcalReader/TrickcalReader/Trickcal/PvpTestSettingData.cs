using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpTestSettingData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Rank { get; set; }
    [Key(2)]
    public string AuthId { get; set; }
    [Key(3)]
    public int[] Units { get; set; }
    [Key(4)]
    public int[] Orders { get; set; }
}
