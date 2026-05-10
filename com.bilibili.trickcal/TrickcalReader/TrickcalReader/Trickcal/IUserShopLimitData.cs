using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserShopLimitData))]
public interface IUserShopLimitData {}
