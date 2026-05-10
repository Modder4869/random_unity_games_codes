using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAlbumReward {
    [Key(0)]
    public int AlbumUid { get; set; }
}
