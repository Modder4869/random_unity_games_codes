using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AuthOkResult {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string AuthToken { get; set; }
    [Key(2)]
    public bool IsNewUser { get; set; }
    [Key(3)]
    public string CreatedId { get; set; }
    [Key(4)]
    public DateTime ServerTime { get; set; }
    [Key(5)]
    public string ServerVersion { get; set; }
    [Key(6)]
    public string TableVersion { get; set; }
    [Key(7)]
    public TitleHeroSettingOperationData TitleHeroSettingOperationData { get; set; }
    [Key(8)]
    public string UserHashTag { get; set; }
    [Key(9)]
    public GameEventData[] GameEvents { get; set; }
}
