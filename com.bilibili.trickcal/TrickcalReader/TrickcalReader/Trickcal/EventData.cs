using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public EventType Category { get; set; }
    [Key(2)]
    public EventConditionType AddCondition { get; set; }
    [Key(3)]
    public int ConditionValue { get; set; }
    [Key(4)]
    public ContentsType Contents { get; set; }
    [Key(5)]
    public int ContentsValue { get; set; }
    [Key(6)]
    public bool IsVisible { get; set; }
    [Key(7)]
    public string BannerTitle { get; set; }
    [Key(8)]
    public string BannerBg { get; set; }
    [Key(9)]
    public int RemainHour { get; set; }
    [Key(10)]
    public string Name { get; set; }
    [Key(11)]
    public string Desc { get; set; }
    [Key(12)]
    public bool BeforeVisible { get; set; }
    [Key(13)]
    public string Desc2 { get; set; }
    [Key(14)]
    public string LongBanner { get; set; }
    [Key(15)]
    public EventSubType SubType { get; set; }
    [Key(16)]
    public bool IsPositive { get; set; }
    [Key(17)]
    public bool IsCheckFirstTimeOnly { get; set; }
    [Key(18)]
    public int OpenOrder { get; set; }
    [Key(19)]
    public bool IsEnded { get; set; }
    [Key(20)]
    public bool EventList { get; set; }
    [Key(21)]
    public int EventBridgeOrder { get; set; }
    [Key(22)]
    public int HomeEventUid { get; set; }
    [Key(23)]
    public string LobbyIcon { get; set; }
}
