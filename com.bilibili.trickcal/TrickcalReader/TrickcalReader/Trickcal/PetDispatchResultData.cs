using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchResultData {
    [Key(0)]
    public int TaskId { get; set; }
    [Key(1)]
    public int[] PetIds { get; set; }
    [Key(2)]
    public int TimeIndex { get; set; }
    [Key(3)]
    public List<Goods> CompleteRewards { get; set; }
    [Key(4)]
    public int RentPetId { get; set; }
    [Key(5)]
    public int PetDispatchId { get; set; }
    [Key(6)]
    public int PetDispatchAttributeRankUid { get; set; }
}
