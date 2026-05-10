using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class WWEDamageData {
    [Key(2)]
    public string TakeDamage { get; set; }
    [Key(3)]
    public AttackType TakeAttackType { get; set; }
    [Key(4)]
    public bool IsCritical { get; set; }
    [Key(5)]
    public string WeakType { get; set; }
}
