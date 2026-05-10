namespace Trickcal.Shared;

public enum WorldRewardState : short {
    None = 0,
    Reward1Received = 1,
    Reward2Received = 2,
    Reward3Received = 4,
    OpenRewardReceived = 8
}
