using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSkillChallengeScorePerData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public MonsterType MonsterType { get; set; }
    [Key(2)]
    public int ScoreValue { get; set; }
}
