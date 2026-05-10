using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MinigameVelaUnitData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public VelaMinigameUnitType UnitType { get; set; }
    [Key(2)]
    public int UnitUid { get; set; }
    [Key(3)]
    public float UnitPosX { get; set; }
    [Key(4)]
    public float UnitPosY { get; set; }
    [Key(5)]
    public float UnitScale { get; set; }
    [Key(6)]
    public string AppearMotion { get; set; }
    [Key(7)]
    public string AppearSound { get; set; }
    [Key(8)]
    public string AppearVoice { get; set; }
    [Key(9)]
    public string DisappearMotion { get; set; }
    [Key(10)]
    public string DisappearSound { get; set; }
    [Key(11)]
    public string DisappearVoice { get; set; }
    [Key(12)]
    public string HitMotion { get; set; }
    [Key(13)]
    public string HitSound { get; set; }
    [Key(14)]
    public string HitVoice { get; set; }
    [Key(15)]
    public string KillMotion { get; set; }
    [Key(16)]
    public string KillSound { get; set; }
    [Key(17)]
    public string KillVoice { get; set; }
}
