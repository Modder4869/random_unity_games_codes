using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserStoryData {
    [Key(0)]
    public int LastRewardEpisodeId { get; set; }
    [Key(1)]
    public BitArray IsUsedFilms { get; set; }
    [Key(2)]
    public int LastCheckedMemorialEpisodeId { get; set; }
    [Key(3)]
    public BitArray IsRenewalEpisodeReads { get; set; }
    [Key(4)]
    public int[] ClearedStageIds { get; set; }
    [Key(5)]
    public int[] NewRewardEpisodeIds { get; set; }
    [Key(6)]
    public BitArray[] NewRewardEpisodeReads { get; set; }
    [Key(7)]
    public BitArray IsWatchedThroughEventWithoutFilms { get; set; }
}
