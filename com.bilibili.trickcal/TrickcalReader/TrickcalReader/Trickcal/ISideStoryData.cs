using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableSideStoryData))]
public interface ISideStoryData {}
