using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrReceiveMail {
    [Key(0)]
    public List<Goods> GoodsList { get; set; }
    [Key(1)]
    public ResultCode MailReceiveResult { get; set; }
}
