namespace Trickcal.Shared;

public enum EasterEggTriggerType : int {
    None = 0,
    HeroAddDeck = 1,
    EnterDeckEdit = 2,
    BeforeHeroInit = 3,
    AfterHeroInit = 4,
    Victory = 5,
    EnterStage = 6,
    HeroSpawn = 7,
    Defeat = 8,
    MyHomeRestaurantEnter = 9,
    GainBattleItem = 10,
    SetLobby = 11,
    StartInteraction = 12,
    EndInteraction = 13,
    EnterStageComplete = 14,
    BattleStart = 15
}
