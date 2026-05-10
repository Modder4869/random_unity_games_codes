using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SubTypeTextInfoData : TableItem<TableData> {
    [Key(0)]
    public string SubTypeUid { get; set; }
    [Key(1)]
    public string EquipStatIcon { get; set; }
    [Key(2)]
    public string IconTextKey { get; set; }
    [Key(3)]
    public string EquipTypeStatTextKey { get; set; }
}
