using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageDrawListData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int CardUid { get; set; }
    [Key(3)]
    public CardType Type { get; set; }
    [Key(4)]
    public int AsideDrawWeight { get; set; }
    [Key(5)]
    public int AsideDrawRuleWeight { get; set; }
    [Key(6)]
    public int AsideLimitCount { get; set; }
    [Key(7)]
    public bool IsSelectedCard { get; set; }
}
