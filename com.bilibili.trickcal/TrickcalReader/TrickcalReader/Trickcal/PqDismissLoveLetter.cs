using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDismissLoveLetter {
    [Key(0)]
    public int HeroId { get; set; }
}
