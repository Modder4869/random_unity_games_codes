using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class HeroAffinityReactionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int SkinUid { get; set; }
    [Key(2)]
    public int HeroUid { get; set; }
    [Key(3)]
    public int ReactionLv { get; set; }
    [Key(4)]
    public ReactionType Reaction { get; set; }
    [Key(5)]
    public int AffinityLv { get; set; }
    [Key(6)]
    public string Voice { get; set; }
    [Key(7)]
    public ReactionAniStateType StateType { get; set; }
    [Key(8)]
    public int VoiceUid { get; set; }
}
