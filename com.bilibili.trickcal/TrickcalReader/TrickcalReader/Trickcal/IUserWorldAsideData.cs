using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserWorldAsideData))]
public interface IUserWorldAsideData {}
