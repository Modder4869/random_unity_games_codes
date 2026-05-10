using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestReloadUserDatabaseValues {
    [Key(0)]
    public IUserContext Uc { get; set; }
}
