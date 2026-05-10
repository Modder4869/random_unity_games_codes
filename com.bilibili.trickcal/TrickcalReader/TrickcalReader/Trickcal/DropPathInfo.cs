using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DropPathInfo {
    [Key(0)]
    public DropPathType DropPathType { get; set; }
    [Key(1)]
    public int StageUid { get; set; }
    [Key(2)]
    public bool IsClearReward { get; set; }
    [Key(3)]
    public bool IsFirstClearReward { get; set; }
}
