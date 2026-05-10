using MessagePack;

namespace Trickcal.Shared;

[Union(0, typeof(CardBuyBattleEvent))]
[Union(1, typeof(SlotMachineBattleEvent))]
[Union(2, typeof(CardRerollBattleEvent))]
[Union(3, typeof(CardLockBattleEvent))]
[Union(4, typeof(TestSkipValidationEvent))]
[Union(5, typeof(CardDrawBattleEvent))]
[Union(6, typeof(HeroLevelUpDownByEffectEvent))]
[Union(7, typeof(CoinGamblingEffectEvent))]
[Union(8, typeof(HeroSkillEvent))]
[Union(9, typeof(MembershipEffectEvent))]
public interface IBattleEvent {}
