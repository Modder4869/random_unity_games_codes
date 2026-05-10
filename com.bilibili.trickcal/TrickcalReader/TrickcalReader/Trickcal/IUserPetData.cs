using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserPetData))]
public interface IUserPetData {}
