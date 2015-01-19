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

namespace SampSharp.GameMode.Events
{
    /// <summary>
    ///     Provides data for the <see cref="BaseMode.PlayerClickTextDraw" /> or
    ///     <see cref="BaseMode.PlayerClickPlayerTextDraw" /> event.
    /// </summary>
    public class PlayerClickTextDrawEventArgs : PlayerEventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the PlayerClickTextDrawEventArgs class.
        /// </summary>
        /// <param name="playerid">Id of the player.</param>
        /// <param name="textdrawid">Id of the textdraw.</param>
        public PlayerClickTextDrawEventArgs(int playerid, int textdrawid) : base(playerid)
        {
            TextDrawId = textdrawid;
        }

        /// <summary>
        ///     Gets the id of the textdraw.
        /// </summary>
        public int TextDrawId { get; private set; }
    }
}