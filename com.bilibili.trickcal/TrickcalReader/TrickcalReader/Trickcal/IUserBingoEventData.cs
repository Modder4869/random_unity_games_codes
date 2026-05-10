using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserBingoEventData))]
public interface IUserBingoEventData {}
