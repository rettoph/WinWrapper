﻿using System;
using System.Collections.Generic;
using System.Text;
using WinWrapper.User32.Enums;

namespace WinWrapper.User32.Structs
{
    /// <summary>
    /// Contains information about a simulated keyboard event.
    /// 
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput
    /// </summary>
    public struct KeyBoardInput
    {
        /// <summary>
        /// A virtual-key code. The code must be a value in the range 1 to 254. If the 
        /// <see cref="dwFlags"/> member specifies <see cref="KeyBoardInputDwFlag.KEYEVENTF_UNICODE"/>, 
        /// wVk must be 0.
        /// </summary>
        public KeyCode wvk { get; set; }

        /// <summary>
        /// A hardware scan code for the key. If <see cref="dwFlags"/> specifies 
        /// <see cref="KeyBoardInputDwFlag.KEYEVENTF_UNICODE"/>, <see cref="wScan"/> 
        /// specifies a Unicode character which is to be sent to the foreground application.
        /// </summary>
        public UInt16 wScan { get; set; }

        /// <summary>
        /// Specifies various aspects of a keystroke.
        /// </summary>
        public KeyBoardInputDwFlag dwFlags { get; set; }

        /// <summary>
        /// The time stamp for the event, in milliseconds. If this parameter is zero, 
        /// the system will provide its own time stamp.
        /// </summary>
        public UInt32 time { get; set; }

        /// <summary>
        /// An additional value associated with the keystroke. Use the 
        /// <see cref="User32.GetMessageExtraInfo"/> function to obtain 
        /// this information.
        /// </summary>
        public IntPtr dwExtraInfo { get; set; }
    }
}
