using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetPetDispatchTaskCompleteTime {
    [Key(0)]
    public int PetDispatchId { get; set; }
    [Key(1)]
    public int TaskId { get; set; }
    [Key(2)]
    public DateTime SetTime { get; set; }
}
