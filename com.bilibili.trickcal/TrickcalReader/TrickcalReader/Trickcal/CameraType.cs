namespace Trickcal.Shared;

public enum CameraType : int {
    None = 0,
    MoveDown = 1,
    MoveUp = 2,
    MoveLeft = 3,
    MoveRight = 4,
    ZoomInLow = 5,
    ZoomInHigh = 6,
    ZoomInBody = 7,
    ZoomInFace = 8,
    ZoomInEye = 9,
    ZoomInSlow = 10,
    Spin = 11,
    Shake = 12,
    ShakeLR = 13,
    Reset = 14,
    RotateZ = 15,
    MoveRelative = 16,
    Move = 17,
    MoveWorldPos = 18,
    ZoomInWorldScale = 19,
    ZoomInOutBounce = 20,
    Max = 21
}
