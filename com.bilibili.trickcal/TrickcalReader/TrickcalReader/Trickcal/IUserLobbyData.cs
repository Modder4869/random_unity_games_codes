using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserLobbyData))]
public interface IUserLobbyData {}
