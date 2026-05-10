using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TournamentEventEntryData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public int EpisodeUid { get; set; }
    [Key(3)]
    public string ChapterTitleImage { get; set; }
    [Key(4)]
    public int UnitUid { get; set; }
    [Key(5)]
    public string Reaction { get; set; }
    [Key(6)]
    public string Resource { get; set; }
    [Key(7)]
    public string Text { get; set; }
    [Key(8)]
    public int[] UnitUids { get; set; }
    [Key(9)]
    public string CreditText { get; set; }
}
