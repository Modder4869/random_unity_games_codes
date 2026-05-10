using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaPickUpData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GachaInfoUid { get; set; }
    [Key(2)]
    public NeedItemType NeedItemType { get; set; }
    [Key(3)]
    public int NeedItemUid { get; set; }
    [Key(4)]
    public int NeedItemCount { get; set; }
    [Key(5)]
    public int RewardHero { get; set; }
    [Key(6)]
    public int SubHero { get; set; }
    [Key(7)]
    public int RewardHeroPosX { get; set; }
    [Key(8)]
    public int SubHeroPosX { get; set; }
    [Key(9)]
    public string MainSkin { get; set; }
    [Key(10)]
    public string SubSkin { get; set; }
    [Key(11)]
    public int RewardHeroPosY { get; set; }
    [Key(12)]
    public int SubHeroPosY { get; set; }
    [Key(13)]
    public int FrontHero { get; set; }
}
