using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DrawGachaponResult {
    [Key(0)]
    public int DropGroupIdx { get; set; }
    [Key(1)]
    public Goods[] Goods { get; set; }
    [Key(2)]
    public int FallbackDropGroupUid { get; set; }
}
