namespace Trickcal.Shared;

public enum UserDailyLotteryStatus : byte {
    NotSelected = 0,
    OutOfTime = 1,
    Selected = 2,
    CanReceiveReward = 3,
    RewardReceived = 4
}
