using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserRecallLimitData))]
public interface IUserRecallLimitData {}
