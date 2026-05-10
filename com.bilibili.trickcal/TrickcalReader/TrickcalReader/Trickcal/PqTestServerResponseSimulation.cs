using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestServerResponseSimulation {
    [Key(0)]
    public TimeSpan SessionBeforeDelayTime { get; set; }
    [Key(1)]
    public TimeSpan GrainDelayTime { get; set; }
    [Key(2)]
    public TimeSpan SessionAfterDelayTime { get; set; }
    [Key(3)]
    public ResultCode ResultCode { get; set; }
    [Key(4)]
    public List<Goods> GoodsList { get; set; }
}
