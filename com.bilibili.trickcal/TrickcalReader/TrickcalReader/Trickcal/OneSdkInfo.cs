using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class OneSdkInfo {
    [Key(0)]
    public string GlobalChannelId { get; set; }
    [Key(1)]
    public string BrandId { get; set; }
    [Key(2)]
    public string AreaId { get; set; }
}
