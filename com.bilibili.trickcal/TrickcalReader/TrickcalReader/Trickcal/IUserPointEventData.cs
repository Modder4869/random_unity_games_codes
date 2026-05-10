using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserPointEventData))]
public interface IUserPointEventData {}
