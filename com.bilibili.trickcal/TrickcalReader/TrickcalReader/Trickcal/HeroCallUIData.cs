using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroCallUIData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public FindResourceType ResourceType { get; set; }
    [Key(2)]
    public string Path { get; set; }
    [Key(3)]
    public string Animation { get; set; }
    [Key(4)]
    public string BackgroundState { get; set; }
    [Key(5)]
    public bool LeftSide { get; set; }
    [Key(6)]
    public float Scale { get; set; }
}
