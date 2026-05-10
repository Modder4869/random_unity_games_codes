using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserThemeEventData))]
public interface IUserThemeEventData {}
