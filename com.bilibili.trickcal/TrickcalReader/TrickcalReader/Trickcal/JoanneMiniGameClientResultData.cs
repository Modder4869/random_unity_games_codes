using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class JoanneMiniGameClientResultData {
    [Key(0)]
    public int Mode { get; set; }
    [Key(1)]
    public int RemainHp { get; set; }
    [Key(2)]
    public int[] Heroes { get; set; }
}
