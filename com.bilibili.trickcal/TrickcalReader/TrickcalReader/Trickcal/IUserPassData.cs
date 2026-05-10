using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserPassData))]
public interface IUserPassData {}
