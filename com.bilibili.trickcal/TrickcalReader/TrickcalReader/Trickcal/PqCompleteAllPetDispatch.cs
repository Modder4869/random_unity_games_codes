using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCompleteAllPetDispatch {
    [Key(0)]
    public int PetDispatchId { get; set; }
}
