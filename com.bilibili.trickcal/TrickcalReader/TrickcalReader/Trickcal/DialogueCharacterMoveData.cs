using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueCharacterMoveData : TableItem<TableData> {
    [Key(0)]
    public string Key { get; set; }
    [Key(1)]
    public DialogueCharacterMoveType MoveType { get; set; }
    [Key(2)]
    public string[] MoveValue { get; set; }
    [Key(3)]
    public DialogueCharacterMoveEaseType EaseType { get; set; }
    [Key(4)]
    public DialogueCharacterMoveLoopType MoveRepeatType { get; set; }
    [Key(5)]
    public float Duration { get; set; }
    [Key(6)]
    public float Delay { get; set; }
    [Key(7)]
    public DialogueCharacterMoveLoopType LoopType { get; set; }
    [Key(8)]
    public int LoopCount { get; set; }
    [Key(9)]
    public bool IsRelative { get; set; }
    [Key(10)]
    public bool IsMoveFlippable { get; set; }
    [Key(11)]
    public bool IsSpineFlippable { get; set; }
    [Key(12)]
    public string Event { get; set; }
}
