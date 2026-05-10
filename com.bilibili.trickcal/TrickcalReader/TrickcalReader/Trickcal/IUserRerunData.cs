using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserRerunData))]
public interface IUserRerunData {}
