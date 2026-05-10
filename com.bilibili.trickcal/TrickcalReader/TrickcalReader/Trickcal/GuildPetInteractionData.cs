using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class GuildPetInteractionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public GuildLobbyZoneType GuildLobbyZoneType { get; set; }
    [Key(2)]
    public string PetMotion { get; set; }
    [Key(3)]
    public float AgainPetMotion { get; set; }
    [Key(4)]
    public int Waitingtime { get; set; }
}
