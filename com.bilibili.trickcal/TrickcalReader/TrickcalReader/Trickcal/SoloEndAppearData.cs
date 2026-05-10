using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndAppearData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public SoloEndAppearType SoloEndAppearType { get; set; }
    [Key(2)]
    public int Day { get; set; }
    [Key(3)]
    public int InteractionGroup { get; set; }
    [Key(4)]
    public string ResourceType1 { get; set; }
    [Key(5)]
    public string ResourcePath1 { get; set; }
    [Key(6)]
    public string Resource1 { get; set; }
    [Key(7)]
    public string ResourceAdd1 { get; set; }
    [Key(8)]
    public string ResourceType2 { get; set; }
    [Key(9)]
    public string ResourcePath2 { get; set; }
    [Key(10)]
    public string Resource2 { get; set; }
    [Key(11)]
    public string ResourceAdd2 { get; set; }
    [Key(12)]
    public int ResourcePosX { get; set; }
    [Key(13)]
    public int ResourcePosY { get; set; }
    [Key(14)]
    public int ResourcePosZ { get; set; }
    [Key(15)]
    public float ResourceScale { get; set; }
    [Key(16)]
    public int NearNpcNum { get; set; }
    [Key(17)]
    public int FarNpcNum { get; set; }
    [Key(18)]
    public string SceneChange { get; set; }
    [Key(19)]
    public string SceneChangeEnd { get; set; }
    [Key(20)]
    public string SceneChangeTitle { get; set; }
    [Key(21)]
    public string SceneChangeLine { get; set; }
    [Key(22)]
    public string Name { get; set; }
    [Key(23)]
    public int BubblePosX { get; set; }
    [Key(24)]
    public int BubblePosY { get; set; }
}
