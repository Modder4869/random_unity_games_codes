using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpGlobalBanData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool IsUse { get; set; }
    [Key(2)]
    public int[] BanUnits { get; set; }
    [Key(3)]
    public string PVPBanHeroTitle { get; set; }
    [Key(4)]
    public string PVPBanHeroDesc { get; set; }
}
