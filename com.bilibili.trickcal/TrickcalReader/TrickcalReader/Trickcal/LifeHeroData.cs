using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeHeroData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int LifeSkillGroup { get; set; }
    [Key(2)]
    public string TaskDefault { get; set; }
    [Key(3)]
    public string TaskLow { get; set; }
    [Key(4)]
    public string TaskMid { get; set; }
    [Key(5)]
    public string TaskHigh { get; set; }
    [Key(6)]
    public string TaskPerfect { get; set; }
    [Key(7)]
    public string TaskSuccess { get; set; }
    [Key(8)]
    public string TaskFail { get; set; }
    [Key(9)]
    public string Mini { get; set; }
    [Key(10)]
    public TableBaseLifeConditionGroupsData ConditionGroups { get; set; }
    [Key(11)]
    public int SpecialRestGroup { get; set; }
    [Key(12)]
    public int[] ArbeitGroup { get; set; }
    [Key(13)]
    public int[] RestGroup { get; set; }
    [Key(14)]
    public int[] BestRewards { get; set; }
    [Key(15)]
    public int[] EpisodeUids { get; set; }
    [Key(16)]
    public int[] EpisodeConUids { get; set; }
    [Key(17)]
    public int StoryEventTask { get; set; }
    [Key(18)]
    public string StoryEventCG { get; set; }
    [Key(19)]
    public TaskSelectType TaskSelectType { get; set; }
    [Key(20)]
    public int[] TaskGroups { get; set; }
}
