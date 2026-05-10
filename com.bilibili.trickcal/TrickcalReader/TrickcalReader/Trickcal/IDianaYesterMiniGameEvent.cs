using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(DianaYesterOnBlockPlacedEvent))]
[Union(1, typeof(DianaYesterOnFallEvent))]
[Union(2, typeof(DianaYesterOnBlackMagicEvent))]
[Union(3, typeof(DianaYesterOnGetWhiteMagicEvent))]
[Union(4, typeof(DianaYesterOnUseWhiteMagicEvent))]
[Union(5, typeof(DianaYesterGainLifeEvent))]
public interface IDianaYesterMiniGameEvent {}
