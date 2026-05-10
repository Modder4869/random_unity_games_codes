using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserGachaponEventData))]
public interface IUserGachaponEventData {}
