﻿using System;
using System.Collections.Generic;
using System.Text;
using WinWrapper.User32.Structs;

namespace WinWrapper.User32.Enums
{
    /// <summary>
    /// <para>A set of bit flags that specify various aspects of mouse motion and 
    /// button clicks. The bits in this member can be any reasonable combination 
    /// of the following values.</para>
    /// 
    /// <para>The bit flags that specify mouse button status are set to indicate changes 
    /// in status, not ongoing conditions.For example, if the left mouse button is 
    /// pressed and held down, <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTDOWN"/>  is set when the left button is 
    /// first pressed, but not for subsequent motions. Similarly, <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTUP"/> 
    /// is set only when the button is first released.</para>
    /// 
    /// <para>You cannot specify both the <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>  flag and either 
    /// <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/>  or <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/>  flags simultaneously in 
    /// the dwFlags parameter, because they both require use of the <see cref="MouseInput.mouseData"/> field.</para>
    /// 
    /// <para>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput">
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput
    /// </a>
    /// </para>
    /// </summary>
    public enum MouseInputDwFlag : UInt32
    {
        /// <summary>
        /// The dx and dy members contain normalized absolute coordinates. If the flag is not 
        /// set, dxand dy contain relative data (the change in position since the last reported 
        /// position). This flag can be set, or not set, regardless of what kind of mouse or other
        /// pointing device, if any, is connected to the system. For further information about 
        /// relative mouse motion, see the following Remarks section.
        /// </summary>
        MOUSEEVENTF_ABSOLUTE = 0x8000,

        /// <summary>
        /// The wheel was moved horizontally, if the mouse has a wheel. The amount of movement 
        /// is specified in mouseData.
        /// 
        /// Windows XP/2000:  This value is not supported.
        /// </summary>
        MOUSEEVENTF_HWHEEL = 0x01000,

        /// <summary>
        /// Movement occurred.
        /// </summary>
        MOUSEEVENTF_MOVE = 0x0001,

        /// <summary>
        /// The WM_MOUSEMOVE messages will not be coalesced. The default behavior is to coalesce 
        /// WM_MOUSEMOVE messages.
        /// 
        /// Windows XP/2000:  This value is not supported.
        /// </summary>
        MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,

        /// <summary>
        /// The left button was pressed.
        /// </summary>
        MOUSEEVENTF_LEFTDOWN = 0x0002,

        /// <summary>
        /// The left button was released.
        /// </summary>
        MOUSEEVENTF_LEFTUP = 0x0004,

        /// <summary>
        /// The right button was pressed.
        /// </summary>
        MOUSEEVENTF_RIGHTDOWN = 0x0008,

        /// <summary>
        /// The right button was released.
        /// </summary>
        MOUSEEVENTF_RIGHTUP = 0x0010,

        /// <summary>
        /// The middle button was pressed.
        /// </summary>
        MOUSEEVENTF_MIDDLEDOWN = 0x0020,

        /// <summary>
        /// The middle button was released.
        /// </summary>
        MOUSEEVENTF_MIDDLEUP = 0x0040,

        /// <summary>
        /// Maps coordinates to the entire desktop. Must be used with MOUSEEVENTF_ABSOLUTE.
        /// </summary>
        MOUSEEVENTF_VIRTUALDESK = 0x4000,

        /// <summary>
        /// The wheel was moved, if the mouse has a wheel. The amount of movement is 
        /// specified in mouseData.
        /// </summary>
        MOUSEEVENTF_WHEEL = 0x0800,

        /// <summary>
        /// An X button was pressed.
        /// </summary>
        MOUSEEVENTF_XDOWN = 0x0080,

        /// <summary>
        /// An X button was released.
        /// </summary>
        MOUSEEVENTF_XUP = 0x0100
    }
}
