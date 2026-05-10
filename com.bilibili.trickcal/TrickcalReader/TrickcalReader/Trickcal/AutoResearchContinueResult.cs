namespace Trickcal.Shared;

public enum AutoResearchContinueResult : short {
    Ok = 0,
    ResearchNotCompleted = 1,
    ResearchNotStarted = 2,
    NextResearchLocked = 3,
    NotEnoughItem = 4,
    EndOfResearch = 5
}
