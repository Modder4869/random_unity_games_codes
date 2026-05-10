using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserItemData))]
public interface IUserItemData {}
