using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	/// <summary>
	/// Extension methods for <see cref="CombatStatType"/>.
	/// </summary>
	public static class CombatStatTypeExtensions
	{
		/// <summary>
		/// Converts the <see cref="CombatStatType"/> value into an <see cref="int"/> value.
		/// </summary>
		/// <param name="stat">Stat to convert.</param>
		/// <returns>Int values that maps to <see cref="CombatStatType"/>.</returns>
		public static int ToKey(this CombatStatType stat)
		{
			return (int)stat;
		}
	}
}
