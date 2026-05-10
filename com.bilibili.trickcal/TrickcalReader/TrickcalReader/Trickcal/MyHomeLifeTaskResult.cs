using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeLifeTaskResult {
    [Key(0)]
    public int TaskId { get; set; }
    [Key(1)]
    public LifeTaskResultType ResultType { get; set; }
    [Key(2)]
    public int? ConditionId { get; set; }
    [Key(3)]
    public ScheduleConditionPickGroupType ConditionDropType { get; set; }
    [Key(4)]
    public int ConditionDropSkillId { get; set; }
    [Key(5)]
    public int AddStress { get; set; }
    [Key(6)]
    public int AddLifeExp { get; set; }
    [Key(7)]
    public List<Goods> AddGoodsList { get; set; }
    [Key(8)]
    public int[] PerfectBonusIndexes { get; set; }
    [Key(9)]
    public List<Goods> ItemEventRewards { get; set; }
}
