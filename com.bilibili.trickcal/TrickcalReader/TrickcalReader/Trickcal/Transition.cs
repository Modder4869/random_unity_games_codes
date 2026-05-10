namespace Trickcal.Shared;

public enum Transition : int {
    None = 0,
    FadeInBlack = 1,
    FadeOutBlack = 2,
    FadeInWhite = 3,
    FadeOutWhite = 4,
    CircleIn = 5,
    CircleOut = 6,
    RightPushIn = 7,
    RightPushOut = 8,
    RightPushBlackIn = 9,
    RightPushBlackOut = 10,
    PlaceIn = 11,
    PlaceOut = 12,
    ColorBarsIn = 13,
    ColorBarsOut = 14,
    SlateIn = 15,
    SlateOut = 16,
    StoryEnd = 17,
    StoryNext = 18,
    EyeOpen = 19,
    EyeClose = 20,
    EyeSecondOpen = 21,
    EyeSecondClose = 22,
    Max = 23
}
