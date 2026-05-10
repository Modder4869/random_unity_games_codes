using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueEmoticonData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string EmoticonType { get; set; }
    [Key(2)]
    public int EmoticonX { get; set; }
    [Key(3)]
    public int EmoticonY { get; set; }
    [Key(4)]
    public int EmoticonScale { get; set; }
    [Key(5)]
    public int EmoticonRotation { get; set; }
    [Key(6)]
    public bool EmoticonFlip { get; set; }
    [Key(7)]
    public float EmoticonTime { get; set; }
    [Key(8)]
    public float EmoticonDelay { get; set; }
}
