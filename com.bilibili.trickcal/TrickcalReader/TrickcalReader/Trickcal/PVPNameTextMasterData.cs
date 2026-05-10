using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PVPNameTextMasterData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int WordType { get; set; }
    [Key(2)]
    public string kr { get; set; }
    [Key(3)]
    public string en { get; set; }
    [Key(4)]
    public string jp { get; set; }
    [Key(5)]
    public string zh_chs { get; set; }
    [Key(6)]
    public string zh_cht { get; set; }
}
