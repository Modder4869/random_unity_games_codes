using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveMailList {
    [Key(0)]
    public int[] MailIdArray { get; set; }
}
