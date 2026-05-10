using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MixedEventLoadingUnitGroupData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int GroupUid { get; set; }
    [Key(2)]
    public string Dialog { get; set; }
    [Key(3)]
    public string UnitTitle { get; set; }
    [Key(4)]
    public int UnitUid { get; set; }
    [Key(5)]
    public string BackgroundColor { get; set; }
    [Key(6)]
    public string BackCircleColor { get; set; }
    [Key(7)]
    public string BackCircleEffectColor { get; set; }
    [Key(8)]
    public string BackCircleBorderColor { get; set; }
    [Key(9)]
    public string UnitTitleColor { get; set; }
    [Key(10)]
    public string UnitNameColor { get; set; }
    [Key(11)]
    public string UnitNameBorderColor { get; set; }
    [Key(12)]
    public string LeftTopImageName { get; set; }
    [Key(13)]
    public string LeftTopImageColor { get; set; }
    [Key(14)]
    public BGIconAnimationType LeftTopAniType { get; set; }
    [Key(15)]
    public string RightTopImageName { get; set; }
    [Key(16)]
    public string RightTopImageColor { get; set; }
    [Key(17)]
    public BGIconAnimationType RightTopAniType { get; set; }
    [Key(18)]
    public string LeftBottomImageName { get; set; }
    [Key(19)]
    public string LeftBottomImageColor { get; set; }
    [Key(20)]
    public BGIconAnimationType LeftBottomAniType { get; set; }
    [Key(21)]
    public string RightBottomImageName { get; set; }
    [Key(22)]
    public string RightBottomImageColor { get; set; }
    [Key(23)]
    public BGIconAnimationType RightBottomAniType { get; set; }
    [Key(24)]
    public bool ApplyUnitSkin { get; set; }
    [Key(25)]
    public string LoadingBarPrimaryColor { get; set; }
    [Key(26)]
    public string LoadingBarSecondaryColor { get; set; }
    [Key(27)]
    public string SceneChangeUnitAnim { get; set; }
    [Key(28)]
    public string SceneChangeEndUnitAnim { get; set; }
}
