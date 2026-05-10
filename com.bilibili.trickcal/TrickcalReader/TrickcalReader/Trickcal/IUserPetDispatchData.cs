using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserPetDispatchData))]
public interface IUserPetDispatchData {}
