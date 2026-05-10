using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class FixBattleSetInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroSetGroupUid { get; set; }
    [Key(2)]
    public int CardGroupUid { get; set; }
}
