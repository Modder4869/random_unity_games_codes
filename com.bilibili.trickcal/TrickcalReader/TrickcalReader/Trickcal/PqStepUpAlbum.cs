using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqStepUpAlbum {
    [Key(0)]
    public int AlbumUid { get; set; }
}
