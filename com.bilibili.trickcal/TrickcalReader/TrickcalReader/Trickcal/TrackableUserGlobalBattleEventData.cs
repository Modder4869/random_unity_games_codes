using MessagePack;

namespace Trickcal.Shared;
using System.Collections;

[MessagePackObject]
public class TrackableUserGlobalBattleEventData {
    [Key(0)]
    public long StackedTotalDamage { get; set; }
    [Key(1)]
    public int RewardedStep { get; set; }
    [Key(2)]
    public DateTime LastPlayTime { get; set; }
    [Key(3)]
    public int[] RentUserIds { get; set; }
    [Key(4)]
    public int RentCount { get; set; }
    [Key(5)]
    public BitArray AttackStepBits { get; set; }
    [Key(6)]
    public BitArray RewardedStepBits { get; set; }
}
