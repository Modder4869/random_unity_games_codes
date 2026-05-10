using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserHeroData))]
public interface IUserHeroData {}
