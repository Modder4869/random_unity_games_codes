using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSaveMyHomeHousingPreset {
    [Key(0)]
    public int PresetId { get; set; }
    [Key(1)]
    public string PresetName { get; set; }
    [Key(2)]
    public MyHomeHousing MyHomeHousing { get; set; }
}
