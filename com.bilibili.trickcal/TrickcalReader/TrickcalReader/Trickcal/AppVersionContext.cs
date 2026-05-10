using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AppVersionContext {
    [Key(0)]
    public List<AppVersionData> AppVersionDataList { get; set; }
}
