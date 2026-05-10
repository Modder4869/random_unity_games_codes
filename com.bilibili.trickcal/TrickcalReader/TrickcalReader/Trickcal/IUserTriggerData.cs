using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserTriggerData))]
public interface IUserTriggerData {}
