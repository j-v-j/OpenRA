#region Copyright & License Information
/*
 * Copyright 2007-2017 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using OpenRA.Traits;

namespace OpenRA.Mods.Common.Traits.Radar
{
	[Desc("When an actor with this trait is in range of an actor with ProvidesRadar, it will temporarily disable the radar minimap for the enemy player.")]
	public class JamsRadarInfo : ITraitInfo
	{
		[Desc("Range for jamming.")]
		public readonly WDist Range = WDist.Zero;

		[Desc("Which diplomatic stances are affected.")]
		public readonly Stance Stances = Stance.Enemy | Stance.Neutral;

		public object Create(ActorInitializer init) { return new JamsRadar(this); }
	}

	public class JamsRadar
	{
		public readonly JamsRadarInfo Info;

		public JamsRadar(JamsRadarInfo info)
		{
			Info = info;
		}
	}
}
