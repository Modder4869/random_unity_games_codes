using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserProfileHeroes {
    [Key(0)]
    public int[] ProfileHeroes { get; set; }
}
