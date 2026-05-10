using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildSearchData {
    [Key(0)]
    public GuildDetailData DetailData { get; set; }
    [Key(1)]
    public string MasterName { get; set; }
    [Key(2)]
    public bool IsJoinRequest { get; set; }
    [Key(3)]
    public int MasterNameplateId { get; set; }
    [Key(4)]
    public int MasterNameStyleId { get; set; }
}
