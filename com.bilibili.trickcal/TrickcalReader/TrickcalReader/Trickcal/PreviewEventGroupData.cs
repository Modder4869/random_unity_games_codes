using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PreviewEventGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool IsVisible { get; set; }
    [Key(2)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(3)]
    public int UnlockValue { get; set; }
    [Key(4)]
    public PreviewPopupType PreviewPopupType { get; set; }
}
