using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqCheckStoryMemorial {
    [Key(0)]
    public List<int> ChapterUids { get; set; }
}
