using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UserProfileData {
    [Key(0)]
    public int UserId { get; set; }
    [Key(1)]
    public string Nickname { get; set; }
    [Key(2)]
    public int Level { get; set; }
    [Key(3)]
    public int UserExp { get; set; }
    [Key(4)]
    public short Birthday { get; set; }
    [Key(5)]
    public string Comment { get; set; }
    [Key(6)]
    public DateTime CreateTime { get; set; }
    [Key(7)]
    public CacheData<UserStatData> UserStatData { get; set; }
    [Key(8)]
    public Dictionary<StageDifficultyType, int> LastClearedStageMap { get; set; }
    [Key(9)]
    public Dictionary<int, int> CardData { get; set; }
    [Key(10)]
    public int IconId { get; set; }
    [Key(11)]
    public int BorderId { get; set; }
    [Key(12)]
    public int NameplateId { get; set; }
    [Key(13)]
    public int GuildId { get; set; }
    [Key(14)]
    public string GuildName { get; set; }
    [Key(15)]
    public string FriendCode { get; set; }
    [Key(16)]
    public int MainProfileHeroId { get; set; }
    [Key(17)]
    public int SoloEndRanking { get; set; }
    [Key(18)]
    public int ClearedTowerStageOrder { get; set; }
    [Key(19)]
    public int SoloRaidRanking { get; set; }
    [Key(20)]
    public int PvpRanking { get; set; }
    [Key(21)]
    public int PvpHighestRanking { get; set; }
    [Key(22)]
    public Dictionary<int, int> MiniGameScore { get; set; }
    [Key(23)]
    public List<int> FurnitureList { get; set; }
    [Key(24)]
    public int DonationLevel { get; set; }
    [Key(25)]
    public Dictionary<int, int> HeroLifeExp { get; set; }
    [Key(26)]
    public Dictionary<int, int> SetInfo { get; set; }
    [Key(27)]
    public Dictionary<MyHomeBuildingType, int> BuildingLevel { get; set; }
    [Key(28)]
    public int GuildHeroId { get; set; }
    [Key(29)]
    public int GuildPetId { get; set; }
    [Key(30)]
    public int SkinCount { get; set; }
    [Key(31)]
    public int SoloRaidTotalRanking { get; set; }
    [Key(32)]
    public int SoloEndTotalRanking { get; set; }
    [Key(33)]
    public string UserHashTag { get; set; }
    [Key(34)]
    public int NameStyleId { get; set; }
}
