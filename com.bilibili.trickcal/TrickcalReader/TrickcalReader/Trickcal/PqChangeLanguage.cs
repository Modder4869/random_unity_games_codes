using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqChangeLanguage {
    [Key(0)]
    public LanguageType Language { get; set; }
}
