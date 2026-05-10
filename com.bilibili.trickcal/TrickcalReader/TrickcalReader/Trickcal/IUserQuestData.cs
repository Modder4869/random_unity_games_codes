using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserQuestData))]
public interface IUserQuestData {}
