using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetMyHomeHousingData {
    [Key(0)]
    public MyHomeHousingDetailData MyHomeHousingDetailData { get; set; }
}
