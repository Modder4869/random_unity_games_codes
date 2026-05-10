using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserDailyTimeEventData))]
public interface IUserDailyTimeEventData {}
