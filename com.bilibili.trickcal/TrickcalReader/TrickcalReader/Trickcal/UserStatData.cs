using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserStatData {
    [Key(0)]
    public List<StatHeroData> StatHeroData { get; set; }
    [Key(1)]
    public List<StatPetData> StatPetData { get; set; }
    [Key(2)]
    public List<StatAlbumData> StatAlbumData { get; set; }
    [Key(3)]
    public int CurrentResearchId { get; set; }
    [Key(4)]
    public List<StatGatherHeroData> StatGatherHeroData { get; set; }
}
