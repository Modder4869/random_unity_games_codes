using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndAuthorityListData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int AuthorityUid { get; set; }
}
