using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnOperationDataChanged {
    [Key(0)]
    public OperationDataContext OpsContext { get; set; }
}
