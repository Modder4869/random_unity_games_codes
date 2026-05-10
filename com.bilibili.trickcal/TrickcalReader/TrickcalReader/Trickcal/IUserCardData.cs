using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserCardData))]
public interface IUserCardData {}
