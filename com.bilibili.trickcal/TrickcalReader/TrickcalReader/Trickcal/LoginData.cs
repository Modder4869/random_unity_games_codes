using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LoginData {
    [Key(0)]
    public IUserContext Uc { get; set; }
    [Key(2)]
    public OperationDataContext OpsContext { get; set; }
    [Key(3)]
    public GuildLoginData GuildLogin { get; set; }
    [Key(4)]
    public string UserHashTag { get; set; }
    [Key(5)]
    public List<WjxActivityResponseItem> UserWjxActivityInfo { get; set; }
    [Key(6)]
    public bool HasPaid { get; set; }
    [Key(7)]
    public BiliChainBatch ChainBatch { get; set; }
}
