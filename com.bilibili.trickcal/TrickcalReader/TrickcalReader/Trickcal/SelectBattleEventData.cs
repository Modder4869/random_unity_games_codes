using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SelectBattleEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int BonusHeroGroupUid { get; set; }
    [Key(2)]
    public int[] EventCurrencyItemUids { get; set; }
    [Key(3)]
    public string SkipBackground { get; set; }
    [Key(4)]
    public bool[] CurrencyExchangable { get; set; }
    [Key(5)]
    public int BattleAvailableTime { get; set; }
    [Key(6)]
    public bool[] ApplyEventBonus { get; set; }
}
