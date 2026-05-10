using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTutorialGachaState {
    [Key(0)]
    public bool IsTutorialGachaCompleted { get; set; }
}
