using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildPetRentData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string UserName { get; set; }
    [Key(2)]
    public int PetId { get; set; }
}
