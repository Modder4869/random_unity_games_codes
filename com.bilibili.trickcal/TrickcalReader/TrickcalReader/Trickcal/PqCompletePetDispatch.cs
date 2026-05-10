using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCompletePetDispatch {
    [Key(0)]
    public int PetDispatchId { get; set; }
    [Key(1)]
    public int TaskId { get; set; }
}
