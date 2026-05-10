using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TutorialStageSettingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Stage { get; set; }
    [Key(3)]
    public int Wave { get; set; }
    [Key(4)]
    public int Draw { get; set; }
    [Key(5)]
    public int Slot { get; set; }
    [Key(6)]
    public TutorialStageSettingCardTypes CardType { get; set; }
    [Key(7)]
    public int CardUid { get; set; }
    [Key(8)]
    public int CardPrice { get; set; }
}
