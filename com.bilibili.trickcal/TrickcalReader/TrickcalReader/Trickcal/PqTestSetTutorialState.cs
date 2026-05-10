using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetTutorialState {
    [Key(0)]
    public int TutorialState { get; set; }
}
