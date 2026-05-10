using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChatDialogue : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int NextEvent { get; set; }
    [Key(2)]
    public int Sender { get; set; }
    [Key(3)]
    public string SenderName { get; set; }
    [Key(4)]
    public string Text { get; set; }
    [Key(5)]
    public string Icon { get; set; }
    [Key(6)]
    public string CGType { get; set; }
    [Key(7)]
    public string CG { get; set; }
    [Key(8)]
    public float StartDelay { get; set; }
    [Key(9)]
    public int TextSpeed { get; set; }
    [Key(10)]
    public string SFX { get; set; }
    [Key(11)]
    public int[] Branch { get; set; }
    [Key(12)]
    public string[] BranchText { get; set; }
    [Key(13)]
    public int EpisodeUid { get; set; }
}
