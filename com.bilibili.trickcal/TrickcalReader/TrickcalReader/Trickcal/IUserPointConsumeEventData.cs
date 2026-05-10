using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserPointConsumeEventData))]
public interface IUserPointConsumeEventData {}
