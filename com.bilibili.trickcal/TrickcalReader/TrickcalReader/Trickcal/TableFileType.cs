using System;
namespace Trickcal.Shared
{
	public enum TableFileType
	{
		[TableFileTarget(TableFileTargetType.All)]
		TrickcalTables = 1,
		[TableFileTarget(TableFileTargetType.All)]
		Kr,
		[TableFileTarget(TableFileTargetType.All)]
		En,
		[TableFileTarget(TableFileTargetType.All)]
		Jp,
		[TableFileTarget(TableFileTargetType.All)]
		Zh_chs,
		[TableFileTarget(TableFileTargetType.All)]
		Zh_cht,
		[TableFileTarget(TableFileTargetType.Client)]
		TrickcalDialogueTable = 1001,
		[TableFileTarget(TableFileTargetType.Client)]
		ScenarioTextKr = 2002,
		[TableFileTarget(TableFileTargetType.Client)]
		ScenarioTextEn,
		[TableFileTarget(TableFileTargetType.Client)]
		ScenarioTextJp,
		[TableFileTarget(TableFileTargetType.Client)]
		ScenarioTextZh_chs,
		[TableFileTarget(TableFileTargetType.Client)]
		ScenarioTextZh_cht
	}
}
