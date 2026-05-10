using System;

namespace Trickcal.Shared
{
	[Flags]
	public enum TableFileTargetType
	{
		Client = 1,
		Server = 2,
		All = 3
	}
}
