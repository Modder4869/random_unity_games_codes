using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestServerInfo {
    [Key(0)]
    public string UserSessionPodName { get; set; }
    [Key(1)]
    public string UserGrainPodName { get; set; }
}
