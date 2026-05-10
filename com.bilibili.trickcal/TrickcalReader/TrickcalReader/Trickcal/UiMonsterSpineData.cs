using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class UiMonsterSpineData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public string SpineName { get; set; }
    [Key(2)]
    public float RaidLobbyScale { get; set; }
    [Key(3)]
    public float RaidLobbyPosX { get; set; }
    [Key(4)]
    public float RaidLobbyPosY { get; set; }
    [Key(5)]
    public Pos RaidLobbyPos { get; set; }
    [Key(6)]
    public float RaidStageInfoScale { get; set; }
    [Key(7)]
    public float RaidStageInfoPosX { get; set; }
    [Key(8)]
    public float RaidStageInfoPosY { get; set; }
    [Key(9)]
    public Pos RaidStageInfoPos { get; set; }
    [Key(10)]
    public float RaidResultScale { get; set; }
    [Key(11)]
    public float RaidResultPosX { get; set; }
    [Key(12)]
    public float RaidResultPosY { get; set; }
    [Key(13)]
    public Pos RaidResultPos { get; set; }
    [Key(14)]
    public float MonsterInfoScale { get; set; }
    [Key(15)]
    public float MonsterInfoPosX { get; set; }
    [Key(16)]
    public float MonsterInfoPosY { get; set; }
    [Key(17)]
    public Pos MonsterInfoPos { get; set; }
    [Key(18)]
    public float AlbumScale { get; set; }
    [Key(19)]
    public float AlbumPosX { get; set; }
    [Key(20)]
    public float AlbumPosY { get; set; }
    [Key(21)]
    public Pos AlbumPos { get; set; }
    [Key(22)]
    public Pos MonsterNotiPos { get; set; }
    [Key(23)]
    public float NotiScale { get; set; }
    [Key(24)]
    public float NotiPosX { get; set; }
    [Key(25)]
    public float NotiPosY { get; set; }
    [Key(26)]
    public Pos MonsterSkipPos { get; set; }
    [Key(27)]
    public float SkipScale { get; set; }
    [Key(28)]
    public float SkipPosX { get; set; }
    [Key(29)]
    public float SkipPosY { get; set; }
    [Key(30)]
    public float MonsterInfoPopupScale { get; set; }
    [Key(31)]
    public float MonsterInfoPopupPosX { get; set; }
    [Key(32)]
    public float MonsterInfoPopupPosY { get; set; }
    [Key(33)]
    public float TrainingRoomScale { get; set; }
    [Key(34)]
    public float TrainingRoomPosX { get; set; }
    [Key(35)]
    public float TrainingRoomPosY { get; set; }
}
