using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserFriendRequestData))]
public interface IUserFriendRequestData {}
