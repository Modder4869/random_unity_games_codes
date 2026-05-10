using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetHomeLab {
    [Key(0)]
    public int ResearchLabUid { get; set; }
}
