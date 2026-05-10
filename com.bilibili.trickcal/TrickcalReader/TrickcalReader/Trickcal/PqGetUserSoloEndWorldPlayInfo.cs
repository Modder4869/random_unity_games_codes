using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqGetUserSoloEndWorldPlayInfo {
    [Key(0)]
    public int SoloEndId { get; set; }
    [Key(1)]
    public int WorldId { get; set; }
    [Key(2)]
    public int UserId { get; set; }
    [Key(3)]
    public int Page { get; set; }
    [Key(4)]
    public int PageLength { get; set; }
}
