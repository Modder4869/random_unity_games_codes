using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeHousingDetailData {
    [Key(0)]
    public MyHomeHousing MyHomeHousing { get; set; }
    [Key(1)]
    public int HomeLevel { get; set; }
    [Key(2)]
    public int[] Heroes { get; set; }
    [Key(3)]
    public List<int> Pets { get; set; }
    [Key(4)]
    public int Fame { get; set; }
    [Key(5)]
    public int[] HeroSkins { get; set; }
    [Key(6)]
    public bool[] AsideOwns { get; set; }
    [Key(7)]
    public short[] AsideGrades { get; set; }
    [Key(8)]
    public int FamePointItemCount { get; set; }
    [Key(9)]
    public Dictionary<int, int[]> HeroSkinDetails { get; set; }
}
