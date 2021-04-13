﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinWrapper.User32.Enums
{
    /// <summary>
    /// Specifies various aspects of a keystroke. This member can be 
    /// certain combinations of the following values.
    /// 
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-keybdinput
    /// </summary>
    public enum KeyBoardInputDwFlag : UInt32
    {
        /// <summary>
        /// If specified, the key is being pressed.
        /// </summary>
        KEYEVENTF_KEYDOWN = 0x0000,

        /// <summary>
        /// If specified, the scan code was preceded by a prefix byte 
        /// that has the value 0xE0 (224).
        /// </summary>
        KEYEVENTF_EXTENDEDKEY = 0x0001,

        /// <summary>
        /// If specified, the key is being released. If not specified, 
        /// the key is being pressed.
        /// </summary>
        KEYEVENTF_KEYUP = 0x0002,

        /// <summary>
        /// If specified, wScan identifies the key and wVk is ignored.
        /// </summary>
        KEYEVENTF_SCANCODE = 0x0008,

        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke.
        /// The wVk parameter must be zero. This flag can only be combined 
        /// with the KEYEVENTF_KEYUP flag. For more information, see the 
        /// Remarks section.
        /// </summary>
        KEYEVENTF_UNICODE = 0x0004
    }
}
