using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCdnDownloadEnd {
    [Key(0)]
    public CdnType CdnType { get; set; }
    [Key(1)]
    public int OldBundleVersion { get; set; }
    [Key(2)]
    public int NewBundleVersion { get; set; }
    [Key(4)]
    public int DownloadFileCount { get; set; }
    [Key(5)]
    public int DurationSeconds { get; set; }
    [Key(6)]
    public long DownloadSizeBytes { get; set; }
}
