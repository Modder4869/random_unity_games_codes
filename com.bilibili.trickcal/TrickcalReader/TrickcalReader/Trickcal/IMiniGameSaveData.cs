using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(RenewaMiniGameSaveData))]
[Union(1, typeof(JoanneMiniGameSaveData))]
[Union(2, typeof(RanMiniGameSaveData))]
[Union(3, typeof(ButterMiniGameSaveData))]
[Union(4, typeof(VelaMiniGameSaveData))]
[Union(5, typeof(DianaYesterMiniGameSaveData))]
[Union(6, typeof(EdEditionMiniGameSaveData))]
[Union(7, typeof(RanEditionMiniGameSaveData))]
public interface IMiniGameSaveData {}
