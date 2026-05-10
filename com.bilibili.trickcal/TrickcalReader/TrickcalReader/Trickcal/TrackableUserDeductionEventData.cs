using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserDeductionEventData {
    [Key(0)]
    public DeductionEventTeamType[] SelectedTeams { get; set; }
    [Key(1)]
    public BitArray IsRewardReceived { get; set; }
    [Key(2)]
    public BitArray IsResultWatched { get; set; }
    [Key(3)]
    public BitArray IsIntroWatched { get; set; }
}
