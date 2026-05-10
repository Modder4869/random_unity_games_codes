using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserPassData {
    [Key(0)]
    public BitArray FreeRewardStates { get; set; }
    [Key(1)]
    public BitArray PaidRewardStates { get; set; }
    [Key(2)]
    public bool IsPaid { get; set; }
    [Key(3)]
    public int Point { get; set; }
    [Key(4)]
    public bool IsPremium { get; set; }
}
