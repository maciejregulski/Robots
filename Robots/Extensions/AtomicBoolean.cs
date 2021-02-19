// 
// Copyright 2013 Hans Wolff
//
// Source: https://gist.github.com/hanswolff/7926751
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
// 
using System.Threading;

namespace Robots.Extensions
{
    /// <summary>
    /// Interlocked support for boolean atomic operation
    /// Modified to meet our demands and replace bool with lock
    /// </summary>
    public class AtomicBoolean
    {
        private const int TRUE_VALUE = 1;
        private const int FALSE_VALUE = 0;

        /// <summary>
        /// Initial value = false
        /// </summary>
        private int zeroOrOne = FALSE_VALUE;

        public AtomicBoolean() : this(false)
        { 
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="initialValue">Sets the initial value</param>
        public AtomicBoolean(bool initialValue)
        {
            this.Value = initialValue;
        }

        /// <summary>
        /// Provides thread-safe access to the backing value
        /// </summary>
        public bool Value
        {
            get
            {
                /// <summary>
                /// Compares the current value and the comparand for equality and, if they are equal, 
                /// replaces the current value with the new value in an atomic/thread-safe operation.
                /// Returns the original value before any operation was performed.
                /// </summary>
                return Interlocked.CompareExchange(ref zeroOrOne, 0, 0) == TRUE_VALUE;
            }
            set
            {
                Interlocked.Exchange(ref zeroOrOne, value ? TRUE_VALUE : FALSE_VALUE);
            }
        }

    }
}