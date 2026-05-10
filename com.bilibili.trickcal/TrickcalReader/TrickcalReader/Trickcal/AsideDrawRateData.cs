using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AsideDrawRateData : TableItem<TableData> {
    [Key(0)]
    public int WaveOrder { get; set; }
    [Key(1)]
    public int HeroRate { get; set; }
    [Key(2)]
    public int[] SpellArtifactRate { get; set; }
    [Key(3)]
    public int AuthorityRate { get; set; }
    [Key(4)]
    public int UltimateSkillRate { get; set; }
}
