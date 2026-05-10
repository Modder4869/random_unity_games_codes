using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class PqUpdateOneSdkAccountBinding {
    [Key(0)]
    public OneSdkAccountBindingType BindingType { get; set; }
}
