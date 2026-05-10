using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestSendMails {
    [Key(0)]
    public int[] MailIdArray { get; set; }
}
