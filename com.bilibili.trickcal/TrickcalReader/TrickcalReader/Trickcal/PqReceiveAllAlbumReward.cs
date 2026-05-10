using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveAllAlbumReward {
    [Key(0)]
    public AlbumType AlbumType { get; set; }
}
