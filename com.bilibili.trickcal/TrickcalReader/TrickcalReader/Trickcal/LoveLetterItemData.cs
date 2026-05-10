using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LoveLetterItemData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public string Resource { get; set; }
    [Key(3)]
    public string LetterDesc { get; set; }
    [Key(4)]
    public TribeType LetterForm { get; set; }
    [Key(5)]
    public TribeType LetterDecoration { get; set; }
    [Key(6)]
    public string LetterVoice { get; set; }
}
