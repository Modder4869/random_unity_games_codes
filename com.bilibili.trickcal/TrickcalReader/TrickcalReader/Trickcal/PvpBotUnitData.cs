using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpBotUnitData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int MinGrade { get; set; }
    [Key(2)]
    public int MaxGrade { get; set; }
    [Key(3)]
    public bool IsContainsEldain { get; set; }
    [Key(4)]
    public SectionType Section { get; set; }
}
