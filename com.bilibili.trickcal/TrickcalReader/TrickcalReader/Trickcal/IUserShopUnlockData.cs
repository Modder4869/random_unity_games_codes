using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserShopUnlockData))]
public interface IUserShopUnlockData {}
