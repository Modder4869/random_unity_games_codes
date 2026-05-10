using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinPassInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SkinUid { get; set; }
    [Key(2)]
    public RewardType[] RewardTypes { get; set; }
    [Key(3)]
    public int[] RewardUids { get; set; }
    [Key(4)]
    public int[] RewardValues { get; set; }
    [Key(5)]
    public string SpineStanding { get; set; }
    [Key(6)]
    public string StandingEffect3DName { get; set; }
    [Key(7)]
    public string PassDesc { get; set; }
    [Key(8)]
    public bool IsDisplayProfileIcon { get; set; }
}
