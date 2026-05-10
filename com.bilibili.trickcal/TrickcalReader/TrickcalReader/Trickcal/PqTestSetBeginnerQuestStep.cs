using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetBeginnerQuestStep {
    [Key(0)]
    public int Step { get; set; }
}
