using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSendMails {
    [Key(0)]
    public Goods[] GoodsArray { get; set; }
}
