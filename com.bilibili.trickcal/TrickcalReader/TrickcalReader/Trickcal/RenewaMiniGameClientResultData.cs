using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class RenewaMiniGameClientResultData {
    [Key(0)]
    public int ModeUid { get; set; }
    [Key(1)]
    public List<RenewaMiniGame_TimeData> TimeDatas { get; set; }
}
