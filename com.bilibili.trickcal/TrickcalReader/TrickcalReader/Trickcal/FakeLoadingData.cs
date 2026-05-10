using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FakeLoadingData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SpinePath { get; set; }
    [Key(2)]
    public string Skin { get; set; }
    [Key(3)]
    public string SceneChange { get; set; }
    [Key(4)]
    public string SceneChangeLine { get; set; }
    [Key(5)]
    public string SceneChangeTitle { get; set; }
    [Key(6)]
    public string Name { get; set; }
    [Key(7)]
    public float SceneChangePosX { get; set; }
    [Key(8)]
    public float SceneChangePosY { get; set; }
    [Key(9)]
    public float SceneChangeScale { get; set; }
    [Key(10)]
    public string SceneChangeEnd { get; set; }
    [Key(11)]
    public int Group { get; set; }
}
