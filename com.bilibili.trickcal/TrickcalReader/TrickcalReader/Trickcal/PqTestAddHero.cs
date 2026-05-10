using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestAddHero {
    [Key(0)]
    public int HeroId { get; set; }
    [Key(1)]
    public int Exp { get; set; }
    [Key(2)]
    public short AddGrade { get; set; }
    [Key(3)]
    public bool IsOverwrite { get; set; }
}
