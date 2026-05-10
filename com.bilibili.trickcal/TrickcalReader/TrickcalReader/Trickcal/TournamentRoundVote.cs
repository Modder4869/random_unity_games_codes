using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TournamentRoundVote {
    [Key(0)]
    public int Round { get; set; }
    [Key(1)]
    public List<int> SelectedTournamentEntryUids { get; set; }
}
