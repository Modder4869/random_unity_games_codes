using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserGachaRecordData))]
public interface IUserGachaRecordData {}
