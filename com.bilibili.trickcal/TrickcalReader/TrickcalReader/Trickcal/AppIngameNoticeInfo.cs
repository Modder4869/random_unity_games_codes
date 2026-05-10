using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AppIngameNoticeInfo {
    [Key(0)]
    public string Message { get; set; }
}
