using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventUIData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RewardType[] ExpectedRewardTypes { get; set; }
    [Key(2)]
    public int[] ExpectedRewardValues { get; set; }
    [Key(3)]
    public string TitleImg { get; set; }
    [Key(4)]
    public string Prefab { get; set; }
    [Key(5)]
    public string Background { get; set; }
    [Key(6)]
    public string PrefabBg { get; set; }
    [Key(7)]
    public string TitleStartAni { get; set; }
    [Key(8)]
    public string TitleLoopAni { get; set; }
    [Key(9)]
    public int GroupSpineUid { get; set; }
    [Key(10)]
    public bool SpineRandomVisible { get; set; }
    [Key(11)]
    public int EventMinimiGroup { get; set; }
}
