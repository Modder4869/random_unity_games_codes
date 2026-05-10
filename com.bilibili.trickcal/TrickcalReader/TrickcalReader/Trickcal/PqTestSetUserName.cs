using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetUserName {
    [Key(0)]
    public string UserName { get; set; }
}
