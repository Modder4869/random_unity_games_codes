using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddCardLevel {
    [Key(0)]
    public int CardId { get; set; }
}
