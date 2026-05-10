using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GlobalSkillActionData : TableItem<TableData> {
    [Key(0)]
    public string Uid { get; set; }
    [Key(1)]
    public string[] HandlerUids { get; set; }
}
