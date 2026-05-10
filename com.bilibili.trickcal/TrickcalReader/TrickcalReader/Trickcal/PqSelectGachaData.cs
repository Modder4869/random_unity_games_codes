using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSelectGachaData {
    [Key(0)]
    public int GachaGroupUid { get; set; }
    [Key(1)]
    public int GachaInfoUid { get; set; }
}
