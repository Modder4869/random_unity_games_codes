using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqProcessBirthday {
    [Key(0)]
    public TimeSpan BaseUtcOffset { get; set; }
}
