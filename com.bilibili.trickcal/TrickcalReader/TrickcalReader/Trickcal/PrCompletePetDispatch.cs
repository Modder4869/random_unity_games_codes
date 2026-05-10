using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrCompletePetDispatch {
    [Key(0)]
    public PetDispatchResultData PetDispatchResultData { get; set; }
}
