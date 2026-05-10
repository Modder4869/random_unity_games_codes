using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GachaResultData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string HeroTitle { get; set; }
    [Key(2)]
    public string Ani { get; set; }
    [Key(3)]
    public string[] CommonLines { get; set; }
    [Key(4)]
    public string[] CommonVoices { get; set; }
    [Key(5)]
    public string[] SpecialLines { get; set; }
    [Key(7)]
    public string[] SpecialVoice { get; set; }
}
