using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserGachaSelectionData {
    [Key(0)]
    public int SelectedGachaDataInfo { get; set; }
}
