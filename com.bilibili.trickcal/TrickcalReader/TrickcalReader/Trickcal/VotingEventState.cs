namespace Trickcal.Shared;

public enum VotingEventState : int {
    None = 0,
    NotFound = 1,
    NotOpened = 2,
    InProgress = 3,
    UnderAggregation = 4,
    VoteFinished = 5
}
