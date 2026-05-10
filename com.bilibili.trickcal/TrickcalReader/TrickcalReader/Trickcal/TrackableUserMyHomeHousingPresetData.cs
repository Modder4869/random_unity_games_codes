using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserMyHomeHousingPresetData {
    [Key(0)]
    public string Name { get; set; }
    [Key(1)]
    public int LayoutId { get; set; }
    [Key(2)]
    public int DummyProperty { get; set; }
    [Key(3)]
    public int[] WallIds { get; set; }
    [Key(4)]
    public int[] ShowcaseIds { get; set; }
    [Key(5)]
    public int[] ShowcaseCollectionIds { get; set; }
    [Key(6)]
    public int[] ShelfIds { get; set; }
    [Key(7)]
    public int[] ShelfCollectionIds { get; set; }
    [Key(8)]
    public int[] BedIds { get; set; }
    [Key(9)]
    public int[] BedCollectionIds { get; set; }
    [Key(10)]
    public int[] FrameIds { get; set; }
    [Key(11)]
    public int[] FrameCollectionIds { get; set; }
    [Key(12)]
    public int[] PegboardIds { get; set; }
    [Key(13)]
    public int[] PegboardCollectionIds { get; set; }
    [Key(14)]
    public int[] TableIds { get; set; }
    [Key(15)]
    public int[] TableCollectionIds { get; set; }
    [Key(16)]
    public int[] ElectronicsIds { get; set; }
    [Key(17)]
    public int[] SpeakerIds { get; set; }
    [Key(18)]
    public int[] SpeakerCollectionIds { get; set; }
    [Key(19)]
    public int[] YoungchunBedIds { get; set; }
    [Key(20)]
    public int[] BigFrameIds { get; set; }
    [Key(21)]
    public int[] BigFrameCollectionIds { get; set; }
    [Key(22)]
    public int[] SplitFrameSIds { get; set; }
    [Key(23)]
    public int[] SplitFrameSCollectionIds { get; set; }
    [Key(24)]
    public int[] SplitFrameMIds { get; set; }
    [Key(25)]
    public int[] SplitFrameMCollectionIds { get; set; }
    [Key(26)]
    public int[] SplitFrameLIds { get; set; }
    [Key(27)]
    public int[] SplitFrameLCollectionIds { get; set; }
}
