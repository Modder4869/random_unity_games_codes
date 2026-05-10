using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableGuildJoinRequestData))]
public interface IGuildJoinRequestData {}
