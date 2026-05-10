using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventLobbyStepData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int Step { get; set; }
    [Key(3)]
    public MixedEventLobbyUnlockType UnlockType { get; set; }
    [Key(4)]
    public int UnlockValue { get; set; }
    [Key(5)]
    public int UnlockExtraValue { get; set; }
    [Key(6)]
    public MixedEventLobbyExtraActionType ExtraActionType { get; set; }
    [Key(7)]
    public string UnlockExtraStringValue { get; set; }
}
