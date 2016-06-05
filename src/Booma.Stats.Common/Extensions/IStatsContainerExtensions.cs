using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	/// <summary>
	/// Extension methods for <see cref="IStatsContainer{TStatType}"/>.
	/// </summary>
	public static class IStatsContainerExtensions
	{
		/// <summary>
		/// Computes the maximum int value of any valid <typeparamref name="TStatType"/> cast.
		/// </summary>
		/// <typeparam name="TStatType"></typeparam>
		/// <param name="statsContainer"></param>
		/// <returns></returns>
		public static int GetMaxMapKeyValue<TStatType>(this IStatsContainer<TStatType> statsContainer)
			where TStatType : struct, IConvertible
		{
			return GetMaxMapKeyValue<TStatType>();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TStatType"></typeparam>
		/// <returns></returns>
		internal static int GetMaxMapKeyValue<TStatType>()
			where TStatType : struct, IConvertible
		{
			//Gets the values of the enum in the container, casts them to int and then finds the max value
			//of the collection to get max value size
			return ((IEnumerable<TStatType>)Enum.GetValues(typeof(TStatType))).Cast<int>().Max();
		}
	}
}
