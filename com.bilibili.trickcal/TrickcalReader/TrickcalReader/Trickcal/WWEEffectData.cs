using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEEffectData {
    [Key(2)]
    public float AxisX { get; set; }
    [Key(3)]
    public float AxisY { get; set; }
    [Key(4)]
    public float AxisZ { get; set; }
    [Key(5)]
    public bool IsActive { get; set; }
    [Key(6)]
    public string FxName { get; set; }
    [Key(7)]
    public float EulerAnglesX { get; set; }
    [Key(8)]
    public float EulerAnglesY { get; set; }
    [Key(9)]
    public float EulerAnglesZ { get; set; }
    [Key(10)]
    public float ScaleX { get; set; }
    [Key(11)]
    public float ScaleY { get; set; }
    [Key(12)]
    public float ScaleZ { get; set; }
    [Key(13)]
    public string Icon { get; set; }
    [Key(14)]
    public float RootX { get; set; }
}
