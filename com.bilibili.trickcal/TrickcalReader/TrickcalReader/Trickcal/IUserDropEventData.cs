using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserDropEventData))]
public interface IUserDropEventData {}
