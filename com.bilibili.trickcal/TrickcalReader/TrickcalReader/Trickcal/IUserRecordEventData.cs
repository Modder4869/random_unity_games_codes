using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserRecordEventData))]
public interface IUserRecordEventData {}
