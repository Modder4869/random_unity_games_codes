using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StageEffectData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public string StartAniName { get; set; }
    [Key(3)]
    public float StartAniDuration { get; set; }
    [Key(4)]
    public int[] StartAniRequiredHero { get; set; }
}
