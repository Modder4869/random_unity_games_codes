using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStartPetDispatch {
    [Key(0)]
    public int PetDispatchId { get; set; }
    [Key(1)]
    public int TaskId { get; set; }
    [Key(2)]
    public int TaskTimeIndex { get; set; }
    [Key(3)]
    public int[] PetIds { get; set; }
    [Key(4)]
    public int GuildRentUserId { get; set; }
    [Key(5)]
    public int GuildRentPetId { get; set; }
}
