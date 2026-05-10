using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCdnDownloadStart {
    [Key(0)]
    public CdnType CdnType { get; set; }
    [Key(1)]
    public int OldBundleVersion { get; set; }
    [Key(2)]
    public int NewBundleVersion { get; set; }
    [Key(4)]
    public int DownloadFileCount { get; set; }
    [Key(5)]
    public long DownloadSizeBytes { get; set; }
}
