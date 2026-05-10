using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CreateOrderResData {
    [Key(0)]
    public string OutTradeNo { get; set; }
    [Key(1)]
    public string NotifyUrl { get; set; }
    [Key(2)]
    public string ExtensionInfo { get; set; }
}
