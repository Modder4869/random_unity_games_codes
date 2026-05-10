using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventChoiceEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public string Title { get; set; }
    [Key(3)]
    public string Desc { get; set; }
    [Key(4)]
    public string[] Choice { get; set; }
    [Key(5)]
    public int[] EventPoint { get; set; }
    [Key(6)]
    public string[] Sprite { get; set; }
    [Key(7)]
    public int[] Interaction { get; set; }
    [Key(8)]
    public int StageUid { get; set; }
    [Key(9)]
    public string[] Icon { get; set; }
}
