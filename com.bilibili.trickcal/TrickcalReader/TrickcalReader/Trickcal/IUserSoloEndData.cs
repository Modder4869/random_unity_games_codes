using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserSoloEndData))]
public interface IUserSoloEndData {}
