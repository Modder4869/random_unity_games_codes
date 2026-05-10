using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserSoloRaidData))]
public interface IUserSoloRaidData {}
