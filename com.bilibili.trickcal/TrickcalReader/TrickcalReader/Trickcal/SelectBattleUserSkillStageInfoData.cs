using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SelectBattleUserSkillStageInfoData : TableItem<TableData> {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int UserSkillGroupUid { get; set; }
    [Key(2)]
    public int GimmickInfoUid { get; set; }
    [Key(3)]
    public string UserSkillPreset { get; set; }
}
