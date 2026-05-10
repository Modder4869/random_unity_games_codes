using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserResourceOccupyEventData))]
public interface IUserResourceOccupyEventData {}
