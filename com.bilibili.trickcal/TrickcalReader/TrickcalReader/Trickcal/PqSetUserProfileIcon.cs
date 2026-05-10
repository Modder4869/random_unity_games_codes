using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetUserProfileIcon {
    [Key(0)]
    public int? ProfileIconId { get; set; }
    [Key(1)]
    public int? ProfileBorderId { get; set; }
    [Key(2)]
    public int? ProfileNameplateId { get; set; }
    [Key(3)]
    public int? ProfileNameStyleId { get; set; }
}
