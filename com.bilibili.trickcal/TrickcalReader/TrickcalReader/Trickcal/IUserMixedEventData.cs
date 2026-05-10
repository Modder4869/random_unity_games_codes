using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserMixedEventData))]
public interface IUserMixedEventData {}
