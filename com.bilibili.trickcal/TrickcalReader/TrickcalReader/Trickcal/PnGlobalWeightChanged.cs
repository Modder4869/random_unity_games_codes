using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnGlobalWeightChanged {
    [Key(0)]
    public SerializedGlobalWeightVariableData SerializedGV { get; set; }
}
