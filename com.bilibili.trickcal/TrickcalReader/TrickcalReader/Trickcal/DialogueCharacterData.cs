using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class DialogueCharacterData : TableItem<TableData> {
    [Key(0)]
    public int EpisodeUid { get; set; }
    [Key(1)]
    public int Uid { get; set; }
    [Key(2)]
    public CharacterType[] CharacterTypes { get; set; }
    [Key(3)]
    public int[] Characters { get; set; }
    [Key(4)]
    public bool[] Flips { get; set; }
    [Key(5)]
    public string[] Motions { get; set; }
    [Key(6)]
    public string[] Moves { get; set; }
    [Key(7)]
    public float[] MoveTimes { get; set; }
    [Key(8)]
    public bool[] MoveRepeats { get; set; }
    [Key(9)]
    public bool[] MoveFlips { get; set; }
    [Key(10)]
    public string[] Skins { get; set; }
    [Key(11)]
    public HighLightType[] HighLights { get; set; }
    [Key(12)]
    public int[] Depths { get; set; }
    [Key(13)]
    public string[] SkinKeys { get; set; }
    [Key(14)]
    public float[] MoveDelays { get; set; }
    [Key(15)]
    public float[] PosX { get; set; }
    [Key(16)]
    public float[] PosY { get; set; }
    [Key(17)]
    public float[] Rotation { get; set; }
    [Key(18)]
    public float[] Scale { get; set; }
    [Key(19)]
    public bool[] Interactables { get; set; }
    [Key(20)]
    public int[] EffectUid { get; set; }
}
