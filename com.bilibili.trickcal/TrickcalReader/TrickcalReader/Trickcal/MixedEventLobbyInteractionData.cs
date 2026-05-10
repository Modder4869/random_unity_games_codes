using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventLobbyInteractionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public MixedEventLobbyInteractionUnlockType[] UnlockType { get; set; }
    [Key(4)]
    public int[] UnlockValue { get; set; }
    [Key(5)]
    public RewardType[] RewardType { get; set; }
    [Key(6)]
    public int[] RewardUid { get; set; }
    [Key(7)]
    public int[] RewardValue { get; set; }
}
