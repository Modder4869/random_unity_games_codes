using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ProductInformationData {
    [Key(0)]
    public string ProductId { get; set; }
    [Key(1)]
    public bool Show { get; set; }
    [Key(2)]
    public long BeginTimeMs { get; set; }
    [Key(3)]
    public long EndTimeMs { get; set; }
    [Key(4)]
    public string Message { get; set; }
}
