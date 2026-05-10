using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEShieldData {
    [Key(15)]
    public string Root { get; set; }
}
