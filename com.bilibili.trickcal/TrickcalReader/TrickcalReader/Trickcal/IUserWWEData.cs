using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserWWEData))]
public interface IUserWWEData {}
