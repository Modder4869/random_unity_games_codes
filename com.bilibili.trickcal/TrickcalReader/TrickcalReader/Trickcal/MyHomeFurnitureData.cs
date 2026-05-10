using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class MyHomeFurnitureData : TableItem<TableData> {
    [Key(0)]
    public TableBaseItemData ItemData { get; set; }
    [Key(1)]
    public FurnitureCategoryType CategoryType { get; set; }
    [Key(2)]
    public FurnitureType Type { get; set; }
    [Key(3)]
    public int Rarity { get; set; }
    [Key(4)]
    public FurnitureSpaceType SpaceType { get; set; }
    [Key(5)]
    public int[] SpaceSize { get; set; }
    [Key(6)]
    public int LimitNum { get; set; }
    [Key(7)]
    public int Sale { get; set; }
    [Key(8)]
    public string Name { get; set; }
    [Key(9)]
    public string Desc { get; set; }
    [Key(10)]
    public string Icon { get; set; }
    [Key(11)]
    public string Resource { get; set; }
    [Key(12)]
    public string Effect { get; set; }
    [Key(16)]
    public int SetUid { get; set; }
    [Key(17)]
    public string EffectSideLeft { get; set; }
    [Key(18)]
    public string EffectSideRight { get; set; }
    [Key(19)]
    public string EffectUpLeft { get; set; }
    [Key(20)]
    public string EffectUpRight { get; set; }
    [Key(21)]
    public string EffectDownLeft { get; set; }
    [Key(22)]
    public string EffectDownRight { get; set; }
}
