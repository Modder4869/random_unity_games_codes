using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserDeductionEventData))]
public interface IUserDeductionEventData {}
