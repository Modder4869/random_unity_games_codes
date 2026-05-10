using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TableApplyData {
    [Key(0)]
    public TableMetadata Metadata { get; set; }
    [Key(1)]
    public byte[][] ExcelTableBytesArray { get; set; }
    [Key(2)]
    public byte[] GameRuleBytes { get; set; }
    [Key(3)]
    public Dictionary<GameDataType, byte[]> GameDatasBytes { get; set; }
}
