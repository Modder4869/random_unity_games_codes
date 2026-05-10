using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrCheckGuildName {
    [Key(0)]
    public bool IsExist { get; set; }
    [Key(1)]
    public bool IsInvalid { get; set; }
}
