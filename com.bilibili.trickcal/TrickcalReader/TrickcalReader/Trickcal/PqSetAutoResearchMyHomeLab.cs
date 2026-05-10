using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetAutoResearchMyHomeLab {
    [Key(0)]
    public bool IsAutoResearchEnabled { get; set; }
}
