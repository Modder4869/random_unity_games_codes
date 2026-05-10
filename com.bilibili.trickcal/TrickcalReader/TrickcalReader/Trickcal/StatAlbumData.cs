using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class StatAlbumData {
    [Key(0)]
    public int AlbumId { get; set; }
    [Key(1)]
    public int Step { get; set; }
}
