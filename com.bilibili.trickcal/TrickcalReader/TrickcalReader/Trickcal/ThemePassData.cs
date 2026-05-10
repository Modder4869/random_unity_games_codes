using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ThemePassData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public RewardType[] RewardType { get; set; }
    [Key(2)]
    public int[] RewardUid { get; set; }
    [Key(3)]
    public int[] RewardValue { get; set; }
    [Key(4)]
    public string Spine01 { get; set; }
    [Key(5)]
    public string Skin01 { get; set; }
    [Key(6)]
    public string NameText01 { get; set; }
    [Key(7)]
    public string TowerDesc { get; set; }
    [Key(8)]
    public string NameDesc { get; set; }
    [Key(9)]
    public string PassDesc01 { get; set; }
    [Key(10)]
    public string PassDesc02 { get; set; }
    [Key(11)]
    public int IdolSkinUid { get; set; }
    [Key(12)]
    public int UserNameStyleUid { get; set; }
}
