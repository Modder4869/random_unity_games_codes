using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueUnitAppearData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EpisodeUid { get; set; }
    [Key(4)]
    public int Sender { get; set; }
    [Key(5)]
    public string SenderName { get; set; }
}
