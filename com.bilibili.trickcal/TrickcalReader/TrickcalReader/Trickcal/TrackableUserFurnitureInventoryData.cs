using MessagePack;

namespace Trickcal.Shared;

[MessagePackObject]
public class TrackableUserFurnitureInventoryData {
    [Key(0)]
    public int[] WallIds { get; set; }
    [Key(1)]
    public int[] ShowcaseIds { get; set; }
    [Key(2)]
    public int[] ShelfIds { get; set; }
    [Key(3)]
    public int[] BedIds { get; set; }
    [Key(4)]
    public int[] FrameIds { get; set; }
    [Key(5)]
    public int[] PegboardIds { get; set; }
    [Key(6)]
    public int[] TableIds { get; set; }
    [Key(7)]
    public int[] ElectronicsIds { get; set; }
    [Key(8)]
    public int[] SpeakerIds { get; set; }
    [Key(9)]
    public int[] FigureIds { get; set; }
    [Key(10)]
    public int[] DollIds { get; set; }
    [Key(11)]
    public int[] PillowIds { get; set; }
    [Key(12)]
    public int[] PosterIds { get; set; }
    [Key(13)]
    public int[] KeyringIds { get; set; }
    [Key(14)]
    public int[] StandIds { get; set; }
    [Key(15)]
    public int[] RecordIds { get; set; }
    [Key(16)]
    public int[] YoungchunBedIds { get; set; }
    [Key(17)]
    public int[] BigFrameIds { get; set; }
    [Key(18)]
    public int[] SplitFrameSIds { get; set; }
    [Key(19)]
    public int[] SplitFrameMIds { get; set; }
    [Key(20)]
    public int[] SplitFrameLIds { get; set; }
}
