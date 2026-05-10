using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MiniEventData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string BackGround { get; set; }
    [Key(2)]
    public int ChapterUid { get; set; }
    [Key(3)]
    public string TitleText { get; set; }
    [Key(4)]
    public string TitleImage { get; set; }
    [Key(5)]
    public string StoryButton { get; set; }
    [Key(6)]
    public string RewardButton { get; set; }
    [Key(7)]
    public string[] TabNames { get; set; }
    [Key(8)]
    public int[] GroupIds { get; set; }
    [Key(9)]
    public bool[] IsVisibles { get; set; }
    [Key(10)]
    public int[] Interactions { get; set; }
    [Key(11)]
    public int PickUpUid { get; set; }
    [Key(12)]
    public string PeriodColor { get; set; }
    [Key(13)]
    public string TitleImageFX { get; set; }
    [Key(14)]
    public int MiniGameUid { get; set; }
    [Key(15)]
    public ContentsUnlockType MiniGameUnlockType { get; set; }
    [Key(16)]
    public int MiniGameUnlockValue { get; set; }
    [Key(17)]
    public string MiniGameButton { get; set; }
    [Key(18)]
    public string BackgroundVideo { get; set; }
    [Key(20)]
    public string GachaButton { get; set; }
    [Key(21)]
    public bool ShopIsVisible { get; set; }
    [Key(22)]
    public string SkinShopButton { get; set; }
    [Key(23)]
    public string GachaButtonFX { get; set; }
    [Key(24)]
    public string SkinShopButtonFX { get; set; }
    [Key(25)]
    public string StoryButtonFX { get; set; }
    [Key(26)]
    public string BGM { get; set; }
    [Key(27)]
    public string AchievementBackground { get; set; }
    [Key(28)]
    public int LobbyInfoUid { get; set; }
}
