using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetAppNotices {
    [Key(0)]
    public List<AppNoticeInfo> NoticeInfos { get; set; }
}
