using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserGachaLimitData))]
public interface IUserGachaLimitData {}
