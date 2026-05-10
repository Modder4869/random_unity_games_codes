using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetGlobalTutorialState {
    [Key(0)]
    public int From { get; set; }
    [Key(1)]
    public int To { get; set; }
    [Key(2)]
    public bool State { get; set; }
}
