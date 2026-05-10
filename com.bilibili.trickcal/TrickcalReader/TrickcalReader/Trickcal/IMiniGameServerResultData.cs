using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(RenewaMiniGameServerResultData))]
[Union(1, typeof(JoanneMiniGameServerResultData))]
[Union(2, typeof(RanMiniGameServerResultData))]
[Union(3, typeof(VelaMiniGameServerResultData))]
[Union(4, typeof(RanEditionMiniGameServerResultData))]
public interface IMiniGameServerResultData {}
