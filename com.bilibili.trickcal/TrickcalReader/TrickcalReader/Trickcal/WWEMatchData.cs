using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEMatchData : TableItem<TableData> {
    [Key(0)]
    public float PlayTime { get; set; }
    [Key(1)]
    public Dictionary<string, List<WWEUnitData>> RecordUnitData { get; set; }
    [Key(2)]
    public Dictionary<string, List<WWEAnimationData>> RecordAnimationData { get; set; }
    [Key(3)]
    public Dictionary<string, List<WWEDamageData>> RecordDamageData { get; set; }
    [Key(4)]
    public Dictionary<string, List<WWEHealData>> RecordHealData { get; set; }
    [Key(5)]
    public Dictionary<string, List<WWESpData>> RecordSpData { get; set; }
    [Key(6)]
    public Dictionary<string, List<WWEEffectData>> RecordEffectData { get; set; }
    [Key(7)]
    public Dictionary<string, List<WWEShieldData>> RecordShieldData { get; set; }
    [Key(8)]
    public Dictionary<string, List<WWEUnitScaleData>> RecordUnitScaleData { get; set; }
    [Key(9)]
    public List<WWESoundData> RecordSoundData { get; set; }
    [Key(10)]
    public List<WWEStageData> RecordStageData { get; set; }
    [Key(11)]
    public List<WWEPlayVoiceData> RecordPlayVoiceData { get; set; }
    [Key(12)]
    public List<WWEMinionSpawnData> RecordMinionSpawnData { get; set; }
    [Key(13)]
    public Dictionary<string, List<WWESpineEffectData>> RecordSpineEffectData { get; set; }
}
