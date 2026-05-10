using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ForcedAuthorityConditionData : TableItem<TableData> {
    [Key(0)]
    public int StageUid { get; set; }
    [Key(1)]
    public int WaveOrder { get; set; }
    [Key(2)]
    public int AuthorityUid { get; set; }
}
