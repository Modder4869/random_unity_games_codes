namespace Trickcal.Shared;

public enum AuthType : short {
    None = 0,
    Guest = 1,
    Google = 2,
    Apple = 4,
    GoogleWithEmail = 8,
    Firebase = 16,
    FirebaseGoogle = 32,
    FirebaseApple = 64,
    BiliBili = 128,
    GuestWithEmail = 4096,
    GmAuthToken = 8192,
    ContinueAuthToken = 16384
}
