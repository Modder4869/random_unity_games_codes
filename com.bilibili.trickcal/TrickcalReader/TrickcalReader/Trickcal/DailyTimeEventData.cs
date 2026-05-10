using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DailyTimeEventData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int Order { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public RewardType[] RewardType { get; set; }
    [Key(4)]
    public int[] RewardUid { get; set; }
    [Key(5)]
    public int[] RewardValue { get; set; }
    [Key(6)]
    public int StartTimeMinuteValue { get; set; }
    [Key(7)]
    public int EndTimeMinuteValue { get; set; }
    [Key(8)]
    public bool PushEnabled { get; set; }
    [Key(9)]
    public string PushTitle { get; set; }
    [Key(10)]
    public string PushMessage { get; set; }
}
