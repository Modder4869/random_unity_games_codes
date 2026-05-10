using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SideStoryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SideStoryGroup { get; set; }
    [Key(2)]
    public int Character { get; set; }
    [Key(3)]
    public int CharacterOrder { get; set; }
    [Key(4)]
    public int Number { get; set; }
    [Key(5)]
    public SideStoryUnlockType UnlockType { get; set; }
    [Key(6)]
    public int UnlockValue { get; set; }
    [Key(7)]
    public string Image { get; set; }
    [Key(8)]
    public string Text { get; set; }
    [Key(9)]
    public RewardType RewardType { get; set; }
    [Key(10)]
    public int RewardUid { get; set; }
    [Key(11)]
    public int RewardValue { get; set; }
}
