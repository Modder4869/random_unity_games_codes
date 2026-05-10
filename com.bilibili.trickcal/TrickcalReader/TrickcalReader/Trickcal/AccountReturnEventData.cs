using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AccountReturnEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(2)]
    public SuppleType[] SuppleTypes { get; set; }
    [Key(3)]
    public int[] SuppleValues { get; set; }
    [Key(4)]
    public int BackGround { get; set; }
    [Key(5)]
    public int ChapterUid { get; set; }
    [Key(6)]
    public int DailyRewardUid { get; set; }
}
