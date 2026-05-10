using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEHealData {
    [Key(2)]
    public string Heal { get; set; }
}
