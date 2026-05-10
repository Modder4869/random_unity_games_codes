using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class AlbumInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public AlbumType AlbumType { get; set; }
    [Key(2)]
    public int TargetUid { get; set; }
    [Key(3)]
    public int RewardUid { get; set; }
    [Key(4)]
    public int RewardValue { get; set; }
    [Key(5)]
    public AlbumRelateStyleType RelateStyle { get; set; }
    [Key(6)]
    public string VoiceActorJpn { get; set; }
    [Key(7)]
    public string VoiceActorKor { get; set; }
}
