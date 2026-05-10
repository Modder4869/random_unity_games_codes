using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(LeetsMiniGameSizeUpFunctionData))]
[Union(1, typeof(LeetsMiniGameReceiveWorldClearRewardFunctionData))]
public interface IMiniGameFunctionData {}
