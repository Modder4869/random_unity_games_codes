using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LayoutInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LayoutGroup { get; set; }
    [Key(2)]
    public int InteractionGroup { get; set; }
    [Key(3)]
    public bool IsDefault { get; set; }
    [Key(4)]
    public int SetUid { get; set; }
    [Key(5)]
    public string MyHomeSkin { get; set; }
    [Key(6)]
    public short[] InviteFloor { get; set; }
    [Key(7)]
    public short[] WallSizeFloor { get; set; }
    [Key(8)]
    public short AddLoveHero { get; set; }
    [Key(9)]
    public string Name { get; set; }
    [Key(10)]
    public string Desc { get; set; }
    [Key(11)]
    public string AniNamePrefix { get; set; }
    [Key(12)]
    public bool GetMaid { get; set; }
    [Key(13)]
    public string Banner { get; set; }
    [Key(14)]
    public RewardType RewardType { get; set; }
    [Key(15)]
    public int RewardUid { get; set; }
    [Key(16)]
    public int RewardValue { get; set; }
    [Key(17)]
    public string MyHomeSkeleton { get; set; }
    [Key(18)]
    public int AddInteractionGroup { get; set; }
    [Key(19)]
    public bool GetPetGather { get; set; }
}
