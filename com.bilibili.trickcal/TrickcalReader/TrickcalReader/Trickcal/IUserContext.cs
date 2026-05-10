using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserContext))]
public interface IUserContext {}
