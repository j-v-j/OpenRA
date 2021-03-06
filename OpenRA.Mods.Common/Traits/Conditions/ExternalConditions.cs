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

namespace OpenRA.Mods.Common.Traits
{
	[Desc("Lists conditions that are accepted from external sources (Lua, warheads, etc).",
		"Externally granted conditions that aren't explicitly whitelisted will be silently ignored.")]
	public class ExternalConditionsInfo : TraitInfo<ExternalConditions>
	{
		[GrantedConditionReference]
		public readonly string[] Conditions = { };
	}

	public class ExternalConditions { }
}
