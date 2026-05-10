using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserHomeEventData))]
public interface IUserHomeEventData {}
