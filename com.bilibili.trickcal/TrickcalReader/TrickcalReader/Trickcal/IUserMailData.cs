using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserMailData))]
public interface IUserMailData {}
