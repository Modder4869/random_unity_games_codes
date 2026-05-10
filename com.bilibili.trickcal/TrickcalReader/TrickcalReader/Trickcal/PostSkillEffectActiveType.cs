namespace Trickcal.Shared;

public enum PostSkillEffectActiveType : int {
    None = 0,
    OnEnd = 1,
    OnRemoved = 2,
    OnEndOrRemoved = 3,
    OnStart = 4,
    StackRemain = 5,
    StackRemove = 6,
    OnTic = 7,
    OnTicWithStart = 8
}
