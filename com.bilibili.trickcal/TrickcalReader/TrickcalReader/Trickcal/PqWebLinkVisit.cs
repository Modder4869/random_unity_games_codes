using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqWebLinkVisit {
    [Key(0)]
    public int EventId { get; set; }
}
