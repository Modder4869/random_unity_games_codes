using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public struct OperationDataKey {
    [Key(0)]
    public OperationDataType Type { get; set; }
    [Key(1)]
    public int DataId { get; set; }
}
