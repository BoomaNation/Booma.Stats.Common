using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Booma.Stats.Common
{
	public static class ImmutableStatsContainerBuilderCarryObjectExtensions
	{
		//generic extensions
		/// <summary>
		/// Sets the desired <typeparamref name="TStatType"/> to the given value.
		/// </summary>
		/// <typeparam name="TStatType">Stat type enum type.</typeparam>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statType">Stat type value to set.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TStatType>.IBuilder WithStat<TStatType>(this ImmutableStatsContainerBuilder<TStatType>.IBuilder builder, TStatType statType, int statValue)
			where TStatType : struct, IConvertible
		{
			//Pretty simple, just initialize the desired stat value.
			builder[statType] = statValue;

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets all <typeparamref name="TStatType"/> values to 0.
		/// </summary>
		/// <typeparam name="TStatType">Stat type enum type.</typeparam>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TStatType>.IBuilder WithDefaults<TStatType>(this ImmutableStatsContainerBuilder<TStatType>.IBuilder builder)
			where TStatType : struct, IConvertible
		{
			return builder.WithAllValuesAs(0);
		}

		/// <summary>
		/// Sets all <typeparamref name="TStatType"/> values to the desired value.
		/// </summary>
		/// <typeparam name="TStatType">Stat type enum type.</typeparam>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TStatType>.IBuilder WithAllValuesAs<TStatType>(this ImmutableStatsContainerBuilder<TStatType>.IBuilder builder, int statValue)
			where TStatType : struct, IConvertible
		{
			//This is ok in Unity. Don't worry about GC.
			foreach (TStatType stat in Enum.GetValues(typeof(TStatType)))
			{
				//Call with stat instead of setting it to consolidate setting logic
				builder.WithStat(stat, statValue);
			}

			//fluent return
			return builder;
		}

		//ResistStatType Extensions
		/// <summary>
		/// Sets <see cref="ResistanceStatType.ElementalFire"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder WithFireResist(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(ResistanceStatType.ElementalFire, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="ResistanceStatType.ElementalDark"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder WithDarkResist(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(ResistanceStatType.ElementalDark, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="ResistanceStatType.ElementalIce"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder WithIceResist(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(ResistanceStatType.ElementalIce, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="ResistanceStatType.ElementalLight"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder WithLightResist(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(ResistanceStatType.ElementalLight, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="ResistanceStatType.ElementalThunder"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder WithThunderResist(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(ResistanceStatType.ElementalThunder, statValue);

			//fluent return
			return builder;
		}

		//CombatStatType Extensions
		/// <summary>
		/// Sets <see cref="CombatStatType.AttackAccuracy"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithAttackAccuracy(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.AttackAccuracy, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.AttackPower"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithAttackPower(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.AttackPower, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.DefensivePower"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithDefensivePower(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.DefensivePower, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.EvasivePower"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithEvasivePower(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.EvasivePower, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.HitPoints"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithHitPoints(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.HitPoints, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.Luck"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithLuck(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.Luck, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.MentalStrength"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithMentalStrength(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.MentalStrength, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="CombatStatType.TechniquePoints"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<CombatStatType>.IBuilder WithTechniquePoints(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(CombatStatType.TechniquePoints, statValue);

			//fluent return
			return builder;
		}

		//TransientStatType Extensions
		/// <summary>
		/// Sets <see cref="TransientStatType.HitPoints"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TransientStatType>.IBuilder WithHitPoints(this ImmutableStatsContainerBuilder<TransientStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(TransientStatType.HitPoints, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="TransientStatType.PhotonBlastCharge"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TransientStatType>.IBuilder WithPhotonBlastCharge(this ImmutableStatsContainerBuilder<TransientStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(TransientStatType.PhotonBlastCharge, statValue);

			//fluent return
			return builder;
		}

		/// <summary>
		/// Sets <see cref="TransientStatType.TechniquePoints"/> stat value to desired value.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <param name="statValue">Stat value to set.</param>
		/// <returns>The builder for fluent chaining.</returns>
		public static ImmutableStatsContainerBuilder<TransientStatType>.IBuilder WithTechniquePoints(this ImmutableStatsContainerBuilder<TransientStatType>.IBuilder builder, int statValue)
		{
			builder.WithStat(TransientStatType.TechniquePoints, statValue);

			//fluent return
			return builder;
		}

		//Build methods
		/// <summary>
		/// Generates the <see cref="ImmutableStatsContainer{TStatType}"/> container with the initialized values.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <returns>The fully constructed immutable stat container.</returns>
		public static ImmutableStatsContainer<ResistanceStatType> Build(this ImmutableStatsContainerBuilder<ResistanceStatType>.IBuilder builder)
		{
			//create a new resistance container
			return new ImmutableResistanceStatsContainer(builder.BuilderDictionary);
		}

		/// <summary>
		/// Generates the <see cref="ImmutableStatsContainer{TStatType}"/> container with the initialized values.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <returns>The fully constructed immutable stat container.</returns>
		public static ImmutableStatsContainer<CombatStatType> Build(this ImmutableStatsContainerBuilder<CombatStatType>.IBuilder builder)
		{
			//create a new combat container
			return new ImmutableCombatStatsContainer(builder.BuilderDictionary);
		}

		/// <summary>
		/// Generates the <see cref="ImmutableStatsContainer{TStatType}"/> container with the initialized values.
		/// </summary>
		/// <param name="builder">The builder object for constructing the stat container.</param>
		/// <returns>The fully constructed immutable stat container.</returns>
		public static ImmutableStatsContainer<TransientStatType> Build(this ImmutableStatsContainerBuilder<TransientStatType>.IBuilder builder)
		{
			//create a new combat container
			return new ImmutableTransientStatsContainer(builder.BuilderDictionary);
		}
	}
}
