using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableMetadata {
    [Key(0)]
    public DateTime CreateTimeUtc { get; set; }
    [Key(1)]
    public DateTime CreateTimeLocal { get; set; }
    [Key(2)]
    public int TableVersion { get; set; }
    [Key(3)]
    public string MinimumRequiredServerVersion { get; set; }
    [Key(4)]
    public string HashCode { get; set; }
}
