using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TrackableUserGlobalBattleEventData))]
public interface IUserGlobalBattleEventData {}
