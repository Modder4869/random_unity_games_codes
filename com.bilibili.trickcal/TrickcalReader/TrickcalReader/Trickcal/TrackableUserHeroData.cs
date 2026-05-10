using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserHeroData {
    [Key(0)]
    public int Flags { get; set; }
    [Key(1)]
    public int Exp { get; set; }
    [Key(2)]
    public short Grade { get; set; }
    [Key(3)]
    public short ActiveSkillLevel { get; set; }
    [Key(4)]
    public short Rank { get; set; }
    [Key(5)]
    public bool[] EquipOwns { get; set; }
    [Key(6)]
    public short[] EquipGrades { get; set; }
    [Key(7)]
    public int[] EquipPoints { get; set; }
    [Key(8)]
    public DateTime OwnTime { get; set; }
    [Key(9)]
    public BitArray[] BoardSteps { get; set; }
    [Key(10)]
    public int LastActiveBoardUid { get; set; }
    [Key(11)]
    public int Affinity { get; set; }
    [Key(12)]
    public DateTime LastEatTime { get; set; }
    [Key(13)]
    public BitArray FoodEaten { get; set; }
    [Key(14)]
    public BitArray FoodReadEpisodes { get; set; }
    [Key(15)]
    public int LifeExp { get; set; }
    [Key(16)]
    public short LifeStress { get; set; }
    [Key(17)]
    public int LifeConditionId { get; set; }
    [Key(18)]
    public int[] AddLifeSkills { get; set; }
    [Key(19)]
    public int[] LifeSkillLevels { get; set; }
    [Key(20)]
    public int[] ShopExchangeCounts { get; set; }
    [Key(21)]
    public short UltimateSkillLevel { get; set; }
    [Key(22)]
    public int LastReceivedAffinityPassReward { get; set; }
    [Key(23)]
    public int FoodEatenCount { get; set; }
    [Key(24)]
    public int SkinId { get; set; }
    [Key(25)]
    public bool AsideOwns { get; set; }
    [Key(26)]
    public short AsideGrade { get; set; }
    [Key(27)]
    public int AsideExp { get; set; }
    [Key(28)]
    public int ScheduleEpisodeReadCount { get; set; }
    [Key(29)]
    public short PassiveSkillLevel { get; set; }
    [Key(30)]
    public short GlobalPassiveSkillLevel { get; set; }
    [Key(31)]
    public bool IsLoveLetterDismissed { get; set; }
    [Key(32)]
    public DateTime[] AffinityRelationStepReachTimes { get; set; }
}
