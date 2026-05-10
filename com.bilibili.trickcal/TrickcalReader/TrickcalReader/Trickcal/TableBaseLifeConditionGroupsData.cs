using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableBaseLifeConditionGroupsData {
    [Key(0)]
    public int PerfectConditionGroupId { get; set; }
    [Key(1)]
    public int SuccessConditionGroupId { get; set; }
    [Key(2)]
    public int FailConditionGroupId { get; set; }
}
