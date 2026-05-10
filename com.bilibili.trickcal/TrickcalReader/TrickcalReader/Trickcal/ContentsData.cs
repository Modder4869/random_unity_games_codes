using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ContentsData : TableItem<TableData> {
    [Key(0)]
    public ContentsType Contents { get; set; }
    [Key(1)]
    public ContentsUnlockType UnlockType { get; set; }
    [Key(2)]
    public int UnlockValue { get; set; }
    [Key(3)]
    public string UnlockDesc { get; set; }
    [Key(4)]
    public string ContentsName { get; set; }
    [Key(5)]
    public string Icon { get; set; }
    [Key(6)]
    public bool UnlockMove { get; set; }
    [Key(7)]
    public int Help { get; set; }
    [Key(9)]
    public bool DirectingCheck { get; set; }
    [Key(10)]
    public int EpisodeUid { get; set; }
    [Key(11)]
    public bool IsBeta { get; set; }
}
