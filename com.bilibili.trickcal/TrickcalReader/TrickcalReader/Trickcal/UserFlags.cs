namespace Trickcal.Shared
{
    [Flags]
    public enum UserFlags : short
    {
        None = 0,
        Deleted = 1,
        WhiteList = 2,
        Test = 4,
        TestGacha = 8
    }
}
