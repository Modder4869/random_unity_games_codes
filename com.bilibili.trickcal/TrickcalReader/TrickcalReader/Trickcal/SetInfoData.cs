using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SetInfoData : TableItem<TableData> {
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public SetType SetType { get; set; }
    [Key(2)]
    public int[] TargetIdArray { get; set; }
    [Key(3)]
    public string Name { get; set; }
    [Key(4)]
    public string Icon { get; set; }
    [Key(5)]
    public string SetCondition { get; set; }
    [Key(6)]
    public int Sort { get; set; }
    [Key(7)]
    public int[] PhotoExcept { get; set; }
}
