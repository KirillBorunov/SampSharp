﻿// SampSharp
// Copyright 2015 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.World;

namespace SampSharp.GameMode.Events
{
    /// <summary>
    ///     Provides data for the <see cref="BaseMode.PlayerDied" /> event.
    /// </summary>
    public class PlayerDeathEventArgs : PlayerEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the PlayerDeathEventArgs class.
        /// </summary>
        /// <param name="playerid">Id of the player.</param>
        /// <param name="killerid">Id of the killer.</param>
        /// <param name="reason">Reason of the death.</param>
        public PlayerDeathEventArgs(int playerid, int killerid, Weapon reason) : base(playerid)
        {
            KillerId = killerid;
            DeathReason = reason;
        }

        /// <summary>
        ///     Gets the id of the killer.
        /// </summary>
        public int KillerId { get; private set; }

        /// <summary>
        ///     Gets the killer.
        /// </summary>
        public GtaPlayer Killer
        {
            get { return KillerId == GtaPlayer.InvalidId ? null : GtaPlayer.FindOrCreate(KillerId); }
        }

        /// <summary>
        ///     Gets the reason of the death.
        /// </summary>
        public Weapon DeathReason { get; private set; }
    }
}