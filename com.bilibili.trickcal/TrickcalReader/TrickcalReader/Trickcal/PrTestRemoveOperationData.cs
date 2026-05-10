using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrTestRemoveOperationData {
    [Key(0)]
    public OperationDataContext OpsContext { get; set; }
}
