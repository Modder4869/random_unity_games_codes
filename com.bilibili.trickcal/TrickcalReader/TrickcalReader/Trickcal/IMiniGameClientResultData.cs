using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(EdMiniGameClientResultData))]
[Union(1, typeof(RenewaMiniGameClientResultData))]
[Union(2, typeof(JoanneMiniGameClientResultData))]
[Union(3, typeof(ButterMiniGameClientResultData))]
[Union(4, typeof(RanMiniGameClientResultData))]
[Union(5, typeof(VelaMiniGameClientResultData))]
[Union(6, typeof(DianaYesterMiniGameClientResultData))]
[Union(7, typeof(LeetsMiniGameClientResultData))]
[Union(8, typeof(EdEditionMiniGameClientResultData))]
[Union(9, typeof(RanEditionMiniGameClientResultData))]
public interface IMiniGameClientResultData {}
