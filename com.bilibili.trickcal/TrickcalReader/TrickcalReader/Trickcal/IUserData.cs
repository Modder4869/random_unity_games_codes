using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserData))]
public interface IUserData {}
