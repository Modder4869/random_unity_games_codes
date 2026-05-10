using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroMotionExperienceInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public HeroExperienceMotionType MotionType { get; set; }
    [Key(3)]
    public string Spine { get; set; }
    [Key(4)]
    public int SkinUid { get; set; }
    [Key(5)]
    public string Sound { get; set; }
    [Key(6)]
    public string ButtonName { get; set; }
    [Key(7)]
    public int Sort { get; set; }
    [Key(8)]
    public bool Loop { get; set; }
}
