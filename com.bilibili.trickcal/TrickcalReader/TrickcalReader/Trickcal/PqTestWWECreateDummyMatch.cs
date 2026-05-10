using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTestWWECreateDummyMatch {
    [Key(0)]
    public List<WWEMatchInfoData> MatchInfos { get; set; }
}
