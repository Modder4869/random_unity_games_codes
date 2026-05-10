using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DeviceInfo {
    [Key(0)]
    public OsType OsType { get; set; }
    [Key(1)]
    public int AppVersion { get; set; }
    [Key(2)]
    public int BundleVersion { get; set; }
    [Key(3)]
    public int ProtocolVersion { get; set; }
    [Key(4)]
    public string DeviceId { get; set; }
    [Key(5)]
    public string GPrestoUuid { get; set; }
    [Key(6)]
    public string AdId { get; set; }
    [Key(7)]
    public string AdjustAdGroup { get; set; }
    [Key(8)]
    public string AdjustCampaign { get; set; }
    [Key(9)]
    public int? MainThreadId { get; set; }
    [Key(10)]
    public string OperatingSystem { get; set; }
    [Key(11)]
    public int? ProcessorCount { get; set; }
    [Key(12)]
    public bool? SupportsVibration { get; set; }
    [Key(13)]
    public string DeviceType { get; set; }
    [Key(14)]
    public string CpuDescription { get; set; }
    [Key(15)]
    public string DeviceName { get; set; }
    [Key(16)]
    public string DeviceUniqueIdentifier { get; set; }
    [Key(17)]
    public string DeviceModel { get; set; }
    [Key(18)]
    public int? SystemMemorySize { get; set; }
    [Key(19)]
    public int? GraphicsDeviceId { get; set; }
    [Key(20)]
    public string GraphicsDeviceName { get; set; }
    [Key(21)]
    public string GraphicsDeviceVendorId { get; set; }
    [Key(22)]
    public string GraphicsDeviceVendor { get; set; }
    [Key(23)]
    public int? GraphicsMemorySize { get; set; }
    [Key(24)]
    public bool? GraphicsMultiThreaded { get; set; }
    [Key(25)]
    public string NpotSupport { get; set; }
    [Key(26)]
    public string GraphicsDeviceVersion { get; set; }
    [Key(27)]
    public string GraphicsDeviceType { get; set; }
    [Key(28)]
    public int? MaxTextureSize { get; set; }
    [Key(29)]
    public bool? SupportsDrawCallInstancing { get; set; }
    [Key(30)]
    public bool? SupportsRayTracing { get; set; }
    [Key(31)]
    public bool? SupportsComputeShaders { get; set; }
    [Key(32)]
    public bool? SupportsGeometryShaders { get; set; }
    [Key(33)]
    public int? GraphicsShaderLevel { get; set; }
    [Key(34)]
    public bool? GraphicsUVStartsAtTop { get; set; }
    [Key(35)]
    public bool IsDebugBuild { get; set; }
    [Key(36)]
    public string EditorVersion { get; set; }
    [Key(37)]
    public string InstallMode { get; set; }
    [Key(38)]
    public string TargetFrameRate { get; set; }
    [Key(39)]
    public string CopyTextureSupport { get; set; }
    [Key(40)]
    public string RenderingThreadingMode { get; set; }
}
