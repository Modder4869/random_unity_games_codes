using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserLotteryEventData))]
public interface IUserLotteryEventData {}
