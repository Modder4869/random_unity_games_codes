using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonSeasonInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public string SeasonName { get; set; }
}
