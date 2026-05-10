using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PvpBotData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int DefaultRank { get; set; }
    [Key(2)]
    public int AccountLevel { get; set; }
    [Key(3)]
    public int BotStatusGroup { get; set; }
    [Key(4)]
    public int[] UnitSlots { get; set; }
    [Key(5)]
    public int[] LevelSlots { get; set; }
    [Key(6)]
    public int[] RankSlots { get; set; }
    [Key(7)]
    public int[] GradeSlots { get; set; }
    [Key(8)]
    public TableBaseStatData Stat { get; set; }
    [Key(9)]
    public int ProfileIcon { get; set; }
    [Key(10)]
    public int BorderlineIcon { get; set; }
}
