using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeLevelUpData : TableItem<TableData> {
    [Key(0)]
    public int Level { get; set; }
    [Key(1)]
    public int UserLv { get; set; }
    [Key(2)]
    public TableBaseMyHomeLevelUpNeedItemData NeedItems { get; set; }
    [Key(3)]
    public int RewardDropId { get; set; }
    [Key(4)]
    public int InviteSlot { get; set; }
    [Key(5)]
    public int FurnStep { get; set; }
    [Key(6)]
    public float Npc1Ratio { get; set; }
    [Key(7)]
    public float Npc2Ratio { get; set; }
    [Key(8)]
    public float Npc3Ratio { get; set; }
    [Key(9)]
    public int NearNum { get; set; }
    [Key(10)]
    public int FarNum { get; set; }
    [Key(11)]
    public int LoveSlot { get; set; }
}
