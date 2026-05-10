using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveMail {
    [Key(0)]
    public int MailId { get; set; }
}
