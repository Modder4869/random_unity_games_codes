using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserStoryData))]
public interface IUserStoryData {}
