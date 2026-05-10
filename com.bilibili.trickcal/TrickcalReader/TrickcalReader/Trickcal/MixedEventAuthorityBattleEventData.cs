using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventAuthorityBattleEventData : TableItem<TableData> {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public StageDifficultyType Difficulty { get; set; }
    [Key(2)]
    public int AuthorityUid { get; set; }
    [Key(3)]
    public int UnitUid { get; set; }
    [Key(4)]
    public string UnitSkin { get; set; }
    [Key(5)]
    public string UnitDefaultAni { get; set; }
    [Key(6)]
    public string UnitSelectAni { get; set; }
    [Key(7)]
    public string SelectSFX { get; set; }
    [Key(8)]
    public string SelectVoice { get; set; }
    [Key(9)]
    public int InteractionUid { get; set; }
    [Key(24)]
    public string UnitSkinKey { get; set; }
}
