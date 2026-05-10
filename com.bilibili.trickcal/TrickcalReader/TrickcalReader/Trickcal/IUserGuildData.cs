using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserGuildData))]
public interface IUserGuildData {}
