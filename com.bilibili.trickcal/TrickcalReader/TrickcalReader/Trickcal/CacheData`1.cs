using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CacheData<T> {
    [Key(0)]
    public byte[] Bytes { get; set; }
    [Key(1)]
    public DateTime LastUpdated { get; set; }
}
