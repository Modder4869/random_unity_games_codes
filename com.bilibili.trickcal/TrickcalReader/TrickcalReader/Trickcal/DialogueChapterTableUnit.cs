using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueChapterTableUnit {
    [Key(0)]
    public int ChapterUid { get; set; }
    [Key(1)]
    public Dictionary<int, Dictionary<int, DialogueData>> DialogueData { get; set; }
    [Key(2)]
    public Dictionary<int, Dictionary<int, DialogueCharacterData>> DialogueCharacterData { get; set; }
}
