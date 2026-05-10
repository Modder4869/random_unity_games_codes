using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PrGetOneSdkAccountBinding {
    [Key(0)]
    public OneSdkAccountBindingType BindingType { get; set; }
}
