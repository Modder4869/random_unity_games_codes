using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PreviewEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool IsLobby { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public int GroupUid { get; set; }
    [Key(4)]
    public RewardType RewardType { get; set; }
    [Key(5)]
    public int RewardUid { get; set; }
    [Key(6)]
    public int RewardValue { get; set; }
    [Key(7)]
    public string ButtonText { get; set; }
    [Key(8)]
    public string ButtonImage { get; set; }
    [Key(9)]
    public string Title { get; set; }
    [Key(10)]
    public string Desc { get; set; }
    [Key(11)]
    public string DescImage { get; set; }
    [Key(12)]
    public string RewardButtonText { get; set; }
}
