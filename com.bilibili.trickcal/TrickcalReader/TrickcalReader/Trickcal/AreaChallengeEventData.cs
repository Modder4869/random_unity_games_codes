using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AreaChallengeEventData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int EventUid { get; set; }
    [Key(2)]
    public AreaChallengeEventType EventType { get; set; }
    [Key(3)]
    public string EventName { get; set; }
    [Key(4)]
    public string EventDesc { get; set; }
    [Key(5)]
    public int EventInteraction { get; set; }
    [Key(6)]
    public string EventDialogue { get; set; }
    [Key(8)]
    public string[] Motion { get; set; }
    [Key(9)]
    public string[] Skin { get; set; }
}
