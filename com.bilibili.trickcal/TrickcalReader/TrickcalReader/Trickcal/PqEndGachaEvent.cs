using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqEndGachaEvent {
    [Key(0)]
    public int[] GachaInfoUids { get; set; }
}
