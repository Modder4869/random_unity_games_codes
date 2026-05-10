using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetTutorialState {
    [Key(0)]
    public int TutorialState { get; set; }
    [Key(1)]
    public bool IsSkip { get; set; }
}
