using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserMyHomeData))]
public interface IUserMyHomeData {}
