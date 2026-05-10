using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonOrderData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public int CuisineUid { get; set; }
    [Key(3)]
    public int EvaluationUid { get; set; }
    [Key(4)]
    public CookingTycoonOrderType OrderType { get; set; }
    [Key(5)]
    public int StandingUid { get; set; }
    [Key(6)]
    public int InteractionUid { get; set; }
    [Key(7)]
    public int[] AvailableStageUid { get; set; }
}
