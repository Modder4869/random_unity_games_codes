using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqLinkAccount {
    [Key(0)]
    public AuthType AuthType { get; set; }
    [Key(1)]
    public string Id { get; set; }
    [Key(2)]
    public string BUid { get; set; }
    [Key(3)]
    public OsType OsType { get; set; }
}
