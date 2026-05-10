using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqReceiveHelpReward {
    [Key(0)]
    public List<int> HelpUids { get; set; }
}
