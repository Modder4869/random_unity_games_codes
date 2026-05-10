using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AppNoticeInfo {
    [Key(0)]
    public AppNoticeType NoticeType { get; set; }
    [Key(1)]
    public string Title { get; set; }
    [Key(2)]
    public string Message { get; set; }
    [Key(3)]
    public string LinkPage { get; set; }
    [Key(4)]
    public DateTime PublishTime { get; set; }
    [Key(5)]
    public int Sort { get; set; }
}
