using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableGuildData))]
public interface IGuildData {}
