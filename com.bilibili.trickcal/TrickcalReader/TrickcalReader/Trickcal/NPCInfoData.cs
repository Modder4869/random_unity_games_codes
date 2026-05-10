using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class NPCInfoData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public bool Available { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public string Desc { get; set; }
    [Key(4)]
    public string Icon { get; set; }
    [Key(5)]
    public string SpineStanding { get; set; }
    [Key(6)]
    public string KeyColor { get; set; }
    [Key(7)]
    public string SpineBattle { get; set; }
    [Key(8)]
    public string ResourceName { get; set; }
    [Key(9)]
    public NPCCheckType GetCheck { get; set; }
    [Key(10)]
    public int GetCheckValue { get; set; }
    [Key(11)]
    public int SkinRefHeroUid { get; set; }
    [Key(12)]
    public bool Interactable { get; set; }
}
