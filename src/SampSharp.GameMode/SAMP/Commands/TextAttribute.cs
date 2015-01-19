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

namespace SampSharp.GameMode.SAMP.Commands
{
    /// <summary>
    ///     Represents an text command-parameter.
    /// </summary>
    public class TextAttribute : ParameterAttribute
    {
        /// <summary>
        ///     Initializes a new instance of the TextAttribute class.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        public TextAttribute(string name) : base(name)
        {
        }

        /// <summary>
        ///     Check if the parameter is well-formatted and return the output.
        /// </summary>
        /// <param name="command">The command text.</param>
        /// <param name="output">The output of this parameter.</param>
        /// <returns>True if the parameter is well-formatted, False otherwise.</returns>
        public override bool Check(ref string command, out object output)
        {
            /*
             * Text should at least be one character long.
             */
            if (command.Length == 0)
            {
                output = null;
                return false;
            }

            output = command;
            command = string.Empty;

            return true;
        }
    }
}