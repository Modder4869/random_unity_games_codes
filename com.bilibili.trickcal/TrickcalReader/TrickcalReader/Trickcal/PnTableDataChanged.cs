using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PnTableDataChanged {
    [Key(0)]
    public string TableVersion { get; set; }
    [Key(1)]
    public SerializedGlobalWeightVariableData SerializedGV { get; set; }
}
