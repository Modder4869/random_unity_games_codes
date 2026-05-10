using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserAssembleEventData))]
public interface IUserAssembleEventData {}
