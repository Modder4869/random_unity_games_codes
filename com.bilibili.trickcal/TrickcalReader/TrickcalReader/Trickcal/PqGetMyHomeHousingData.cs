using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetMyHomeHousingData {
    [Key(0)]
    public int UserId { get; set; }
}
