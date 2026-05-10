using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserRecordData))]
public interface IUserRecordData {}
