using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserFriendContextData))]
public interface IUserFriendContextData {}
