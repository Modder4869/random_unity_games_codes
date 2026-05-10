using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(TowerBattleGameData))]
public interface IGameData {}
