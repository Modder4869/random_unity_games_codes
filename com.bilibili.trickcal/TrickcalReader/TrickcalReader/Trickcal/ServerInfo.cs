using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ServerInfo {
    [Key(0)]
    public ServerType ServerType { get; set; }
    [Key(1)]
    public string Address { get; set; }
    [Key(2)]
    public int AppPort { get; set; }
    [Key(3)]
    public int AppAdminPort { get; set; }
    [Key(4)]
    public int AppWithProxyProtocolPort { get; set; }
    [Key(5)]
    public int AppManagementPort { get; set; }
    [Key(6)]
    public int GmToolPort { get; set; }
    [Key(7)]
    public bool IsIngress { get; set; }
    [Key(8)]
    public string DefaultCdnUrl { get; set; }
    [Key(9)]
    public string TableName { get; set; }
    [Key(10)]
    public string Name { get; set; }
    [Key(11)]
    public string Description { get; set; }
    [Key(12)]
    public string ServerVersionString { get; set; }
    [Key(13)]
    public DateTime CreateTime { get; set; }
    [Key(14)]
    public DateTime UpdateTime { get; set; }
    [Key(15)]
    public PublishingType PublishingType { get; set; }
}
