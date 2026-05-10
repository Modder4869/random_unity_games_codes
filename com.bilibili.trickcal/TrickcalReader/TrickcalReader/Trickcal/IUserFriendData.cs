using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserFriendData))]
public interface IUserFriendData {}
