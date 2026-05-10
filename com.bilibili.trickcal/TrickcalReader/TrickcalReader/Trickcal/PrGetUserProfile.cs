using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetUserProfile {
    [Key(0)]
    public UserProfileData UserProfileData { get; set; }
}
