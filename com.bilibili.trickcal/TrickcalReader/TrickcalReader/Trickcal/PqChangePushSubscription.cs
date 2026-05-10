using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangePushSubscription {
    [Key(0)]
    public PushSubscriptionTypes SubscriptionType { get; set; }
}
