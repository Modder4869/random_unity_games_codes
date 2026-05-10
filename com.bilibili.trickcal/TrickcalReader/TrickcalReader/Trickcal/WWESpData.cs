using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWESpData {
    [Key(2)]
    public int GetSp { get; set; }
}
