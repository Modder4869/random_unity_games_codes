using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public bool Available { get; set; }
    [Key(3)]
    public string Name { get; set; }
    [Key(4)]
    public string Desc { get; set; }
    [Key(5)]
    public string Spine { get; set; }
    [Key(6)]
    public string Resource { get; set; }
    [Key(7)]
    public string Icon { get; set; }
    [Key(8)]
    public int EpisodeUid { get; set; }
    [Key(9)]
    public string[] GetAni { get; set; }
    [Key(10)]
    public string[] GetText { get; set; }
    [Key(11)]
    public string[] GetVoice { get; set; }
    [Key(12)]
    public string[] UpgradeAni { get; set; }
    [Key(13)]
    public string[] UpgradeText { get; set; }
    [Key(14)]
    public string[] UpgradeVoice { get; set; }
}
