using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserMiniGameData))]
public interface IUserMiniGameData {}
