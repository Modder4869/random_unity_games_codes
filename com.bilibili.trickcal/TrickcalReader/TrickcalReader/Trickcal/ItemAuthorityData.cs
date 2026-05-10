using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class ItemAuthorityData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(2)]
    public int Cost { get; set; }
    [Key(3)]
    public int SelectRate { get; set; }
    [Key(5)]
    public string Icon { get; set; }
    [Key(6)]
    public string AuthorityAction { get; set; }
    [Key(7)]
    public string Desc { get; set; }
    [Key(8)]
    public string Detail { get; set; }
    [Key(9)]
    public float CoolTime { get; set; }
    [Key(10)]
    public TableBaseCardData CardData { get; set; }
    [Key(11)]
    public AuthorityType Type { get; set; }
    [Key(12)]
    public string AnimationPrefab { get; set; }
    [Key(13)]
    public string[] AnimationParams { get; set; }
}
