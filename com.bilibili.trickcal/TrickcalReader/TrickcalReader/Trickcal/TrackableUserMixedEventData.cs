using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMixedEventData {
    [Key(0)]
    public int SaveLobbyStep { get; set; }
    [Key(1)]
    public int[] ReceivedLobbyRewardUids { get; set; }
    [Key(2)]
    public BitArray ReceivedScoreEventSteps { get; set; }
    [Key(3)]
    public short[] CurrentBalances { get; set; }
    [Key(4)]
    public int[] ReceivedBalanceRewardUids { get; set; }
    [Key(5)]
    public int[] SelectedCardIds { get; set; }
    [Key(6)]
    public int TournamentEventVoteCount { get; set; }
    [Key(7)]
    public int TournamentEventLastWinnerEntryUid { get; set; }
    [Key(8)]
    public BitArray ReceivedLobbyInteractionUids { get; set; }
}
