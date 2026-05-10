using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TowerBattleInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int PlayObjectGroup { get; set; }
    [Key(2)]
    public int WaitingObjectGroup { get; set; }
    [Key(3)]
    public int SpecialObjectUid { get; set; }
    [Key(4)]
    public int BaseObjectUid { get; set; }
    [Key(5)]
    public int DefaultScore { get; set; }
    [Key(6)]
    public int HelpUid { get; set; }
    [Key(7)]
    public int QuestGroup { get; set; }
    [Key(8)]
    public int TurnTime { get; set; }
    [Key(9)]
    public float Gravity { get; set; }
    [Key(10)]
    public int LobbyQuestGroup { get; set; }
    [Key(11)]
    public int DailyQuestGroup { get; set; }
    [Key(12)]
    public int AchievementQuestGroup { get; set; }
}
