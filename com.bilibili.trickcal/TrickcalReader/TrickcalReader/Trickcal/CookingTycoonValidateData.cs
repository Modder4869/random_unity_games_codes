using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class CookingTycoonValidateData {
    [Key(0)]
    public int OrderUid { get; set; }
    [Key(1)]
    public int Score { get; set; }
    [Key(2)]
    public CookingTycoonDishGrade Grade { get; set; }
    [Key(3)]
    public List<int> IngredientUid { get; set; }
    [Key(4)]
    public List<int> IngredientAmount { get; set; }
    [Key(5)]
    public bool IsReOrdered { get; set; }
}
