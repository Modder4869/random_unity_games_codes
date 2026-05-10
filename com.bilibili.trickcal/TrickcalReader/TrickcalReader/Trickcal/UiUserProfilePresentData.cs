using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiUserProfilePresentData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int HeroUid { get; set; }
    [Key(2)]
    public string Resource { get; set; }
    [Key(3)]
    public float PresentX { get; set; }
    [Key(4)]
    public float PresentY { get; set; }
    [Key(5)]
    public float PresentChangeScale { get; set; }
    [Key(6)]
    public Pos PresentPos { get; set; }
}
