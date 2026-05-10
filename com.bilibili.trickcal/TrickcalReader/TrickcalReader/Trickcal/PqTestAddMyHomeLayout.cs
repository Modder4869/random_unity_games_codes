using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddMyHomeLayout {
    [Key(0)]
    public int LayoutId { get; set; }
}
