using System;
using System.Collections.Generic;
using System.Text;
using WinWrapper.User32.Enums;

namespace WinWrapper.User32.Structs
{
    /// <summary>
    /// Used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.
    /// </summary>
    public struct Input
    {
        /// <summary>
        /// The type of the input event. This member can be one of the following values.
        /// </summary>
        public InputType type { get; set; }

        /// <summary>
        /// The information about a simulated event.
        /// 
        /// See: MouseInput
        /// </summary>
        public InputUnion u { get; set; }
    }
}
