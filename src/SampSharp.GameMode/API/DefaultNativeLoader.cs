// SampSharp
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

using System;

namespace SampSharp.GameMode.API
{
    /// <summary>
    ///     Represents the default SA-MP natives loader.
    /// </summary>
    public class DefaultNativeLoader : INativeLoader
    {
        #region Implementation of INativeLoader

        /// <summary>
        ///     Loads a native with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="sizes">The references to the parameter which contains the size of array parameters.</param>
        /// <param name="parameterTypes">The parameter types.</param>
        /// <returns>
        ///     The loaded native.
        /// </returns>
        public INative Load(string name, int[] sizes, Type[] parameterTypes)
        {
            try
            {
                return new Native(name, sizes, parameterTypes);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///     Checks whether a native with the specified <paramref name="name" /> exists.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        ///     True if a native with the specified name exists; False otherwise.
        /// </returns>
        public bool Exists(string name)
        {
            return Interop.NativeExists(name);
        }

        #endregion
    }
}