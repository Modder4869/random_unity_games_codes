using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestSetOperationData {
    [Key(0)]
    public OperationDataContext OpsContext { get; set; }
}
