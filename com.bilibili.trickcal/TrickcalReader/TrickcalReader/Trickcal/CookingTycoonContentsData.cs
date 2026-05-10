using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonContentsData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int ContentsUid { get; set; }
    [Key(2)]
    public CookingTycoonContentsType LobbyContentsType { get; set; }
    [Key(3)]
    public CookingTycoonContentsType GameplayContentsType { get; set; }
    [Key(4)]
    public CookingTycoonContentsType AchievementContentsType { get; set; }
    [Key(5)]
    public CookingTycoonContentsType RankingContentsType { get; set; }
    [Key(6)]
    public CookingTycoonContentsType SeasonRewardContentsType { get; set; }
    [Key(7)]
    public CookingTycoonContentsType StageListContentsType { get; set; }
    [Key(8)]
    public CookingTycoonContentsType LoadingContentsType { get; set; }
    [Key(9)]
    public CookingTycoonContentsType OpeningContentsType { get; set; }
}
