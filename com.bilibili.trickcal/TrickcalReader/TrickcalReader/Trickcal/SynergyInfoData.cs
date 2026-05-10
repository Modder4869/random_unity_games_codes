using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SynergyInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Sort { get; set; }
    [Key(2)]
    public SynergyCategory Category { get; set; }
    [Key(3)]
    public string TypeName { get; set; }
    [Key(4)]
    public string TypeDesc { get; set; }
    [Key(5)]
    public SynergyCondition Condition { get; set; }
    [Key(6)]
    public string Name { get; set; }
    [Key(7)]
    public string Desc { get; set; }
    [Key(8)]
    public string Icon { get; set; }
    [Key(9)]
    public SynergyType SynergyType { get; set; }
}
