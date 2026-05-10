using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ChaosArenaInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(3)]
    public int NormalRuleGroupUid { get; set; }
    [Key(4)]
    public int AdditionRuleGroupUid { get; set; }
    [Key(5)]
    public int HelpUid { get; set; }
    [Key(6)]
    public int ChapterUid { get; set; }
    [Key(7)]
    public ChaosArenaLobbyType LobbyType { get; set; }
}
