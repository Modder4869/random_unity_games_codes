using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserChatEventEpisodeData))]
public interface IUserChatEventEpisodeData {}
