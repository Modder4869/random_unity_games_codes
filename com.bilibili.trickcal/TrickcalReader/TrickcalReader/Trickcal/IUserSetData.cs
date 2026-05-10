using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserSetData))]
public interface IUserSetData {}
