namespace Trickcal.Shared;

public enum VersionCheckReason : byte {
    None = 0,
    Auth = 1,
    ReConnectAuth = 2,
    ReConnectContinueAuth = 3
}
