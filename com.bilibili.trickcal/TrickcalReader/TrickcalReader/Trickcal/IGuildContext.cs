using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableGuildContext))]
public interface IGuildContext {}
