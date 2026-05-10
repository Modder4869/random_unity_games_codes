using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiHeroStandingSpineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SpineName { get; set; }
    [Key(2)]
    public string[] Face { get; set; }
    [Key(3)]
    public float CardScale { get; set; }
    [Key(4)]
    public float CardPosX { get; set; }
    [Key(5)]
    public float CardPosY { get; set; }
    [Key(6)]
    public float ResultScale { get; set; }
    [Key(7)]
    public float ResultPosX { get; set; }
    [Key(8)]
    public float ResultPosY { get; set; }
    [Key(9)]
    public string[] ResultVictory { get; set; }
    [Key(10)]
    public string[] ResultDefeat { get; set; }
    [Key(11)]
    public Pos CardPos { get; set; }
    [Key(12)]
    public Pos ResultPos { get; set; }
    [Key(13)]
    public string StressLow { get; set; }
    [Key(14)]
    public string StressMid { get; set; }
    [Key(15)]
    public string StressHigh { get; set; }
    [Key(16)]
    public string TaskDefault { get; set; }
    [Key(17)]
    public string TaskLow { get; set; }
    [Key(18)]
    public string TaskMid { get; set; }
    [Key(19)]
    public string TaskHigh { get; set; }
    [Key(20)]
    public string TaskPerfect { get; set; }
    [Key(21)]
    public string TaskSuccess { get; set; }
    [Key(22)]
    public string TaskFail { get; set; }
    [Key(23)]
    public string[] LifeSkills { get; set; }
    [Key(24)]
    public float MyHomeScale { get; set; }
    [Key(25)]
    public string PositiveCondition { get; set; }
    [Key(26)]
    public string NegativeCondition { get; set; }
    [Key(27)]
    public string NoneCondition { get; set; }
    [Key(28)]
    public string FoodLike { get; set; }
    [Key(29)]
    public string FoodNormal { get; set; }
    [Key(30)]
    public string FoodHate { get; set; }
    [Key(31)]
    public string LoveHeroAni { get; set; }
    [Key(32)]
    public string LoveHeroCancelAni { get; set; }
    [Key(33)]
    public string SceneChange { get; set; }
    [Key(34)]
    public string SceneChangeEnd { get; set; }
    [Key(35)]
    public float SceneChangePosX { get; set; }
    [Key(36)]
    public float SceneChangePosY { get; set; }
    [Key(37)]
    public Pos SceneChangePos { get; set; }
    [Key(38)]
    public string SceneChangeLine { get; set; }
    [Key(39)]
    public float[] AttendancePosX { get; set; }
    [Key(40)]
    public float[] AttendancePosY { get; set; }
    [Key(41)]
    public float[] AttendanceScale { get; set; }
    [Key(42)]
    public string ResultRankDown { get; set; }
    [Key(43)]
    public float DefaultScale { get; set; }
    [Key(44)]
    public float HeroAsideScale { get; set; }
    [Key(45)]
    public float DefaultPosX { get; set; }
    [Key(46)]
    public float HeroInfoPosFlipX { get; set; }
    [Key(47)]
    public float DefaultPosY { get; set; }
    [Key(48)]
    public Pos DefaultPos { get; set; }
    [Key(49)]
    public Pos HeroInfoPosFlip { get; set; }
    [Key(50)]
    public string SceneChangeTitle { get; set; }
    [Key(51)]
    public float AsidePosX { get; set; }
    [Key(52)]
    public float AsidePosY { get; set; }
    [Key(53)]
    public float SpawnEffectDelay { get; set; }
    [Key(54)]
    public float TalkBubbleX { get; set; }
    [Key(55)]
    public string RunCondition { get; set; }
    [Key(56)]
    public string FeverCondition { get; set; }
    [Key(57)]
    public float GachaPosX { get; set; }
    [Key(58)]
    public float GachaPosY { get; set; }
    [Key(59)]
    public float ThemeEventNavigationButtonPosX { get; set; }
    [Key(60)]
    public float ThemeEventNavigationButtonPosY { get; set; }
    [Key(61)]
    public string ThemeEventNavigationButtonMotion { get; set; }
    [Key(62)]
    public float SkinBgPosY { get; set; }
}
