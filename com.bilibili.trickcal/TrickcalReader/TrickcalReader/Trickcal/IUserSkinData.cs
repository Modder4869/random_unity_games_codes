using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserSkinData))]
public interface IUserSkinData {}
