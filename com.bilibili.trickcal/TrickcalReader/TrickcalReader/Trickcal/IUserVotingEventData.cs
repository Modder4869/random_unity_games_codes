using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserVotingEventData))]
public interface IUserVotingEventData {}
