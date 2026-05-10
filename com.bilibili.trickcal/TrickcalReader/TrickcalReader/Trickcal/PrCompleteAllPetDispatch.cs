using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrCompleteAllPetDispatch {
    [Key(0)]
    public List<PetDispatchResultData> PetDispatchResultDatas { get; set; }
}
