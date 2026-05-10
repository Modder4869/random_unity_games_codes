using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeGuildNotice {
    [Key(0)]
    public string Notice { get; set; }
}
