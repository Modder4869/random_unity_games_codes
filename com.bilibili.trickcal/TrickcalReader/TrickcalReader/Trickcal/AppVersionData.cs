using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AppVersionData {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public string Sender { get; set; }
    [Key(2)]
    public OsType OsType { get; set; }
    [Key(3)]
    public int AppVersion { get; set; }
    [Key(4)]
    public int BundleVersion { get; set; }
    [Key(5)]
    public bool IsForceUpdate { get; set; }
    [Key(6)]
    public bool IsRedirect { get; set; }
    [Key(7)]
    public string RedirectServer { get; set; }
    [Key(8)]
    public DateTime CreateTime { get; set; }
    [Key(9)]
    public bool IsAdminOnly { get; set; }
}
