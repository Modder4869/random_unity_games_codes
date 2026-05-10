using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqTournamentEventGetVotingInfo {
    [Key(0)]
    public int MixedEventUid { get; set; }
}
