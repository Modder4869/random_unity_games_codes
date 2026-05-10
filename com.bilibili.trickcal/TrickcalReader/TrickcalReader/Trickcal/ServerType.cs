namespace Trickcal.Shared;

public enum ServerType : int {
    Local = 1,
    LocalBili = 2,
    Dev = 101,
    DevBili = 102,
    BiliCbt = 103,
    BiliRelease = 104,
    Review = 2001,
    Production = 2002,
    PrivateLocal = 3001,
    Custom = 3002,
    IntegrationTestKr = 9001,
    IntegrationTestLocalKr = 9002,
    IntegrationTestLocalBili = 9003
}
