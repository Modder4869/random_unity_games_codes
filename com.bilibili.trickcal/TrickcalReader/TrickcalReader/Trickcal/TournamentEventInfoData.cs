using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TournamentEventInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int EntryGroup { get; set; }
    [Key(2)]
    public int StepGroup { get; set; }
    [Key(3)]
    public int OpenDelayHour { get; set; }
    [Key(4)]
    public int NeedItemUid { get; set; }
    [Key(5)]
    public int NeedItemCount { get; set; }
    [Key(6)]
    public string StartReaction { get; set; }
    [Key(7)]
    public string StartResource { get; set; }
    [Key(8)]
    public string StartText { get; set; }
    [Key(9)]
    public string EndReaction { get; set; }
    [Key(10)]
    public string EndResource { get; set; }
    [Key(11)]
    public string EndText { get; set; }
    [Key(12)]
    public int StartUnitUid { get; set; }
    [Key(13)]
    public int EndUnitUid { get; set; }
}
