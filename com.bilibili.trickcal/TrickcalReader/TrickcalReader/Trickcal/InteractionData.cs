using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class InteractionData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public InteractionContentsType ContentsType { get; set; }
    [Key(2)]
    public int Group { get; set; }
    [Key(3)]
    public InteractionType Type { get; set; }
    [Key(4)]
    public int Value { get; set; }
    [Key(5)]
    public int[] Units { get; set; }
    [Key(6)]
    public string[] Motions { get; set; }
    [Key(7)]
    public InteractionSenderType Sender { get; set; }
    [Key(8)]
    public string Text { get; set; }
    [Key(9)]
    public string Voice { get; set; }
    [Key(10)]
    public string SFX { get; set; }
    [Key(11)]
    public int SFXLoop { get; set; }
    [Key(12)]
    public string BGM { get; set; }
    [Key(13)]
    public int Ratio { get; set; }
    [Key(14)]
    public int Order { get; set; }
    [Key(15)]
    public int NextInteraction { get; set; }
    [Key(16)]
    public string[] Skins { get; set; }
    [Key(17)]
    public string[] SkinKeys { get; set; }
    [Key(18)]
    public SpineUnitType[] UnitTypes { get; set; }
}
