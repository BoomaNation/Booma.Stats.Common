using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	/// <summary>
	/// Extension methods for <see cref="ResistanceStatType"/>.
	/// </summary>
	public static class ResistanceStateTypeExtensions
	{
		/// <summary>
		/// Converts the <see cref="ResistanceStatType"/> value into an <see cref="int"/> value.
		/// </summary>
		/// <param name="stat">Stat to convert.</param>
		/// <returns>Int values that maps to <see cref="ResistanceStatType"/>.</returns>
		public static int ToKey(this ResistanceStatType stat)
		{
			return (int)stat;
		}
	}
}
