using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class SoloEndWorldListData : TableItem<TableData> {
    [Key(0)]
    public int GroupUid { get; set; }
    [Key(1)]
    public int WorldUid { get; set; }
    [Key(2)]
    public SoloEndWorldType WorldType { get; set; }
    [Key(3)]
    public int WorldOrder { get; set; }
    [Key(4)]
    public PersonalityType Personality { get; set; }
    [Key(5)]
    public string TitleIcon { get; set; }
    [Key(6)]
    public int[] WorldRuleUid { get; set; }
    [Key(7)]
    public GroupType GroupType { get; set; }
    [Key(8)]
    public SoloEndKey SoloEndKey { get; set; }
}
