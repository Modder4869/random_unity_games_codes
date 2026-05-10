using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ExtraTutorialServerSaveData : TableItem<TableData> {
    [Key(0)]
    public TutorialSaveType TutorialSaveType { get; set; }
    [Key(1)]
    public int Index { get; set; }
}
