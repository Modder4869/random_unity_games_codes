using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PetDispatchTaskData : TableItem<TableData> {
    [Key(0)]
    public int Uid { get; set; }
    [Key(1)]
    public int Group { get; set; }
    [Key(2)]
    public string Name { get; set; }
    [Key(3)]
    public int[] TaskTimes { get; set; }
    [Key(5)]
    public int[] ConditionAttributeUids { get; set; }
    [Key(6)]
    public float LocalPositionX { get; set; }
    [Key(7)]
    public float LocalPositionY { get; set; }
    [Key(8)]
    public float Width { get; set; }
    [Key(9)]
    public float Height { get; set; }
    [Key(10)]
    public string SpawnAnimation { get; set; }
    [Key(11)]
    public string WaitAnimation { get; set; }
    [Key(12)]
    public string CompleteAnimation { get; set; }
    [Key(13)]
    public int AnimationGroupUid { get; set; }
    [Key(14)]
    public string Sprite { get; set; }
    [Key(15)]
    public string TaskDesc { get; set; }
    [Key(16)]
    public string TaskResultTimeIcon { get; set; }
    [Key(17)]
    public string TaskResultNamePlate { get; set; }
    [Key(18)]
    public float PetAreaPosX { get; set; }
    [Key(19)]
    public float PetAreaPosY { get; set; }
    [Key(20)]
    public float PetAreaWidth { get; set; }
    [Key(21)]
    public float PetAreaHeight { get; set; }
    [Key(22)]
    public float TaskObjectPosX { get; set; }
    [Key(23)]
    public float TaskObjectPosY { get; set; }
    [Key(24)]
    public float TaskObjectWidth { get; set; }
    [Key(25)]
    public float TaskObjectHeight { get; set; }
    [Key(26)]
    public float NamePlatePosX { get; set; }
    [Key(27)]
    public float NamePlatePosY { get; set; }
    [Key(28)]
    public bool IsWaterSection { get; set; }
    [Key(29)]
    public string TaskPlace { get; set; }
    [Key(30)]
    public string EffectName { get; set; }
}
