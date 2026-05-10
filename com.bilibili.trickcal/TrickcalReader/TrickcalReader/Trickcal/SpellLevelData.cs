using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SpellLevelData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Level { get; set; }
    [Key(2)]
    public int[] StatParam { get; set; }
    [Key(3)]
    public int[] Param { get; set; }
    [Key(4)]
    public int Cost { get; set; }
    [Key(7)]
    public string[] StatParamNew { get; set; }
    [Key(8)]
    public string[] ParamNew { get; set; }
    [Key(9)]
    public string[] UpgradeTexts { get; set; }
    [Key(10)]
    public string[] UpgradeValues { get; set; }
}
