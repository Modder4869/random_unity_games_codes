using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCompleteExtraTutorial {
    [Key(0)]
    public int ExtraTutorialUid { get; set; }
    [Key(1)]
    public bool IsSkip { get; set; }
}
