using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableGuildMemberData))]
public interface IGuildMemberData {}
