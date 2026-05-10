using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserShopData))]
public interface IUserShopData {}
