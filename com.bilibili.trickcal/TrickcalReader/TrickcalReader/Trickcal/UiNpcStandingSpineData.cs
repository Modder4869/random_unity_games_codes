using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiNpcStandingSpineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SpineName { get; set; }
    [Key(2)]
    public float MyHomeScale { get; set; }
    [Key(3)]
    public float[] AttendancePosX { get; set; }
    [Key(4)]
    public float[] AttendancePosY { get; set; }
    [Key(5)]
    public float[] AttendanceScale { get; set; }
    [Key(6)]
    public float TalkBubbleX { get; set; }
    [Key(7)]
    public string SceneChange { get; set; }
    [Key(8)]
    public string SceneChangeEnd { get; set; }
    [Key(9)]
    public float SceneChangePosX { get; set; }
    [Key(10)]
    public float SceneChangePosY { get; set; }
    [Key(11)]
    public Pos SceneChangePos { get; set; }
    [Key(12)]
    public string SceneChangeTitle { get; set; }
    [Key(13)]
    public string SceneChangeLine { get; set; }
    [Key(14)]
    public float DefaultScale { get; set; }
    [Key(15)]
    public float DefaultPosX { get; set; }
    [Key(16)]
    public float DefaultPosY { get; set; }
    [Key(17)]
    public Pos DefaultPos { get; set; }
    [Key(18)]
    public float SkinInfoScale { get; set; }
    [Key(19)]
    public float SkinInfoPosX { get; set; }
    [Key(20)]
    public float SkinInfoPosY { get; set; }
    [Key(21)]
    public Pos SkinInfoPos { get; set; }
}
