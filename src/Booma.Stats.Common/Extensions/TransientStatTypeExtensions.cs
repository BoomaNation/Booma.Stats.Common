using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	/// <summary>
	/// Extension methods for <see cref="TransientStatType"/>.
	/// </summary>
	public static class TransientStatTypeExtensions
	{
		/// <summary>
		/// Converts the <see cref="TransientStatType"/> value into an <see cref="int"/> value.
		/// </summary>
		/// <param name="stat">Stat to convert.</param>
		/// <returns>Int values that maps to <see cref="TransientStatType"/>.</returns>
		public static int ToKey(this TransientStatType stat)
		{
			return (int)stat;
		}
	}
}
