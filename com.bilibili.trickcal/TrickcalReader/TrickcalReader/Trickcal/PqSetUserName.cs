using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserName {
    [Key(0)]
    public string UserName { get; set; }
}
