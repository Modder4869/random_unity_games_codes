using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserDailyLotteryEventData))]
public interface IUserDailyLotteryEventData {}
