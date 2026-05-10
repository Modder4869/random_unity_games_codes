using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SkinDetailData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SkinUid { get; set; }
    [Key(2)]
    public int Order { get; set; }
    [Key(3)]
    public SkinDetailType Type { get; set; }
    [Key(4)]
    public string SkinDetailSpineValue { get; set; }
    [Key(5)]
    public string SkinDetailImage { get; set; }
    [Key(6)]
    public string SkinDetailName { get; set; }
    [Key(7)]
    public bool DefaultOn { get; set; }
}
