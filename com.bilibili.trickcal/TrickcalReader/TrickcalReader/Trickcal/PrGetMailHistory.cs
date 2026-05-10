using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetMailHistory {
    [Key(0)]
    public List<UserMailHistoryData> MailHistory { get; set; }
}
