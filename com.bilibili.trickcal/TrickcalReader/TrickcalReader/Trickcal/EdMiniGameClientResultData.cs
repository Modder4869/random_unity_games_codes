using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class EdMiniGameClientResultData {
    [Key(0)]
    public Dictionary<int, Dictionary<int, int>> HeroGradeCountMap { get; set; }
}
