using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LifeTaskData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public LifeTaskType Type { get; set; }
    [Key(2)]
    public MyHomeContentsType ContentsType { get; set; }
    [Key(3)]
    public int ContentsValue { get; set; }
    [Key(4)]
    public int Grade { get; set; }
    [Key(5)]
    public int[] TaskSkills { get; set; }
    [Key(6)]
    public int DefaultProb { get; set; }
    [Key(7)]
    public int Reward { get; set; }
    [Key(8)]
    public int FailReward { get; set; }
    [Key(9)]
    public int PerfectReward { get; set; }
    [Key(10)]
    public int Stress { get; set; }
    [Key(11)]
    public int LifeExp { get; set; }
    [Key(12)]
    public string Name { get; set; }
    [Key(13)]
    public TableBaseLifeConditionGroupsData ConditionGroups { get; set; }
    [Key(14)]
    public string MiniType { get; set; }
    [Key(15)]
    public string BGBack { get; set; }
    [Key(16)]
    public string BGFront { get; set; }
    [Key(17)]
    public int RewardEvent { get; set; }
    [Key(19)]
    public LifeTaskResultType FixedResult { get; set; }
    [Key(20)]
    public int Group { get; set; }
    [Key(21)]
    public LifeTaskSubType SubType { get; set; }
}
