using MessagePack;
using System.Collections;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserEventHeroData {
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
    public DateTime OwnTime { get; set; }
    [Key(8)]
    public BitArray[] BoardSteps { get; set; }
    [Key(9)]
    public int Affinity { get; set; }
    [Key(10)]
    public short UltimateSkillLevel { get; set; }
    [Key(11)]
    public bool AsideOwns { get; set; }
    [Key(12)]
    public short AsideGrade { get; set; }
    [Key(13)]
    public int AsideExp { get; set; }
    [Key(14)]
    public short PassiveSkillLevel { get; set; }
    [Key(15)]
    public short GlobalPassiveSkillLevel { get; set; }
    [Key(16)]
    public int[] GrowGroupLevels { get; set; }
}
