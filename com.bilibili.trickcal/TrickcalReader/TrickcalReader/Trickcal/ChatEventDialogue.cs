using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatEventDialogue : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EpisodeUid { get; set; }
    [Key(2)]
    public int NextEvent { get; set; }
    [Key(3)]
    public int Sender { get; set; }
    [Key(4)]
    public float Delay { get; set; }
    [Key(5)]
    public string Text { get; set; }
    [Key(6)]
    public int[] Branch { get; set; }
    [Key(7)]
    public string[] BranchText { get; set; }
}
