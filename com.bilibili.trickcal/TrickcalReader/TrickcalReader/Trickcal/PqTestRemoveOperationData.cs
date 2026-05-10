using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestRemoveOperationData {
    [Key(0)]
    public List<IOperationData> OperationData { get; set; }
}
