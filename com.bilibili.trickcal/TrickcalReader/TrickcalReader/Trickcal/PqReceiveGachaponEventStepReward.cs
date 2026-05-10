using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveGachaponEventStepReward {
    [Key(0)]
    public int GachaponEventUid { get; set; }
    [Key(1)]
    public int Step { get; set; }
}
