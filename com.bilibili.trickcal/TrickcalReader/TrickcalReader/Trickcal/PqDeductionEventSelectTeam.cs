using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqDeductionEventSelectTeam {
    [Key(0)]
    public int MixedEventUid { get; set; }
    [Key(1)]
    public DeductionEventTeamType TeamType { get; set; }
}
