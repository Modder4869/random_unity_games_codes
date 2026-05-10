using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserTileEventData))]
public interface IUserTileEventData {}
