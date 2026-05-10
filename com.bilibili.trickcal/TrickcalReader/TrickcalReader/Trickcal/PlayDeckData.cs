using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PlayDeckData {
    [Key(0)]
    public UserDeckKey DeckKey { get; set; }
    [Key(1)]
    public int GuildRentUserId { get; set; }
    [Key(2)]
    public int GuildRentHeroId { get; set; }
    [Key(3)]
    public int GuildHeroRentKey { get; set; }
    [Key(4)]
    public int[] FixBattleFixedHeroes { get; set; }
    [Key(5)]
    public int[] FixBattleOwnedHeroes { get; set; }
    [Key(6)]
    public int GuildRentHeroPosition { get; set; }
}
