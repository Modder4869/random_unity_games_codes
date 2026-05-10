namespace Trickcal.Shared;

public enum ArtifactTriggerConditionType : int {
    None = 0,
    OnUnitInDeck = 1,
    OnStatusEffect = 2,
    CheckCountStatusEffect = 3,
    OnStatusEffectUid = 4
}
