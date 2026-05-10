using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CheckAppUpdateRequiredResult {
    [Key(0)]
    public int RequiredAppVersion { get; set; }
    [Key(1)]
    public string AppUpdateUrl { get; set; }
}
