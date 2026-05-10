using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueAffinityData : TableItem<TableData> {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public DialogueAffinityType[] BranchAffinities { get; set; }
}
