using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestSetMyHomeContentsLevel {
    [Key(0)]
    public MyHomeContentsType ContentsType { get; set; }
    [Key(1)]
    public short Level { get; set; }
}
