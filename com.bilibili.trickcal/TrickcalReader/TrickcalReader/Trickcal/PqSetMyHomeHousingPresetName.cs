using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqSetMyHomeHousingPresetName {
    [Key(0)]
    public int PresetId { get; set; }
    [Key(1)]
    public string PresetName { get; set; }
}
