using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetOperationData {
    [Key(0)]
    public List<IOperationData> OperationData { get; set; }
}
