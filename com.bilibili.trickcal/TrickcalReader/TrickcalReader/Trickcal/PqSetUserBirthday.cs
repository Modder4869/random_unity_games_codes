using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserBirthday {
    [Key(0)]
    public short Month { get; set; }
    [Key(1)]
    public short Day { get; set; }
}
