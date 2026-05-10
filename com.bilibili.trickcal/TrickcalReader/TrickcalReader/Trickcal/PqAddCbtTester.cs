using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqAddCbtTester {
    [Key(0)]
    public string Email { get; set; }
}
