using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserSimpleData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public int Exp { get; set; }
    [Key(3)]
    public DateTime? LastLogoutTime { get; set; }
    [Key(4)]
    public int ProfileBorderId { get; set; }
    [Key(5)]
    public int ProfileIconId { get; set; }
    [Key(6)]
    public int ProfileNameplateId { get; set; }
    [Key(7)]
    public int ProfileNameStyleId { get; set; }
}
