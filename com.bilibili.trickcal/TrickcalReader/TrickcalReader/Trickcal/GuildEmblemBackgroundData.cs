using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildEmblemBackgroundData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string Name { get; set; }
    [Key(2)]
    public string Desc { get; set; }
    [Key(3)]
    public string Icon { get; set; }
    [Key(4)]
    public int Sort { get; set; }
}
