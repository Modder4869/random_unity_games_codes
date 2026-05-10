using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class LoginAttendanceData {
    [Key(0)]
    public int AttendanceDays { get; set; }
    [Key(1)]
    public List<int> HeroRewards { get; set; }
    [Key(2)]
    public List<Goods> GoodsRewards { get; set; }
}
