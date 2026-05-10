using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserNpcData))]
public interface IUserNpcData {}
