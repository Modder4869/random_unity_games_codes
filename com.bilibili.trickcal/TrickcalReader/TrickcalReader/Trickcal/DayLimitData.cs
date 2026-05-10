using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DayLimitData : TableItem<TableData> {
    [Key(0)]
    public int EventUid { get; set; }
    [Key(1)]
    public int Day { get; set; }
    [Key(2)]
    public string[] Ani { get; set; }
    [Key(3)]
    public string[] TalkBox { get; set; }
    [Key(4)]
    public string[] Panel { get; set; }
    [Key(5)]
    public bool TitlePrefab { get; set; }
    [Key(6)]
    public string[] LockDialogue { get; set; }
    [Key(7)]
    public string[] LockAni { get; set; }
    [Key(8)]
    public bool Stick { get; set; }
    [Key(9)]
    public int[] HeroUid { get; set; }
    [Key(10)]
    public string[] SkinName { get; set; }
    [Key(11)]
    public int[] LockHeroUid { get; set; }
    [Key(12)]
    public string[] LockSkinName { get; set; }
    [Key(13)]
    public string BackGround { get; set; }
    [Key(14)]
    public string BackGroundEffect { get; set; }
    [Key(15)]
    public string BGM { get; set; }
    [Key(16)]
    public string[] PointText { get; set; }
}
