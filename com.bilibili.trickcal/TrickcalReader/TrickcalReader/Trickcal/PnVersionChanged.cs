using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnVersionChanged {
    [Key(0)]
    public int AppVersion { get; set; }
    [Key(1)]
    public int BundleVersion { get; set; }
}
