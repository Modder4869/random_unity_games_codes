using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TriggerPopupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public TriggerPopupTriggerType TriggerType { get; set; }
    [Key(2)]
    public TriggerPopupConditionType ConditionType { get; set; }
    [Key(3)]
    public int ConditionValue { get; set; }
    [Key(4)]
    public TriggerPopupPopupType PopupPopupType { get; set; }
}
