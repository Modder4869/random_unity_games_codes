using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserCardDeckData))]
public interface IUserCardDeckData {}
