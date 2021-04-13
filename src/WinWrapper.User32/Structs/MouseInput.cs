﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using WinWrapper.User32.Enums;

namespace WinWrapper.User32.Structs
{
    /// <summary>
    /// <para>Contains information about a simulated mouse event.</para>
    /// 
    /// <para>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput">
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput
    /// </a>
    /// </para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        /// <summary>
        /// The absolute position of the mouse, or the amount of motion since the last 
        /// mouse event was generated, depending on the value of the <see cref="dwFlags"/> 
        /// member. Absolute data is specified as the x coordinate of the mouse; relative data 
        /// is specified as the number of pixels moved.
        /// </summary>
        public Int32 dx { get; set; }

        /// <summary>
        /// The absolute position of the mouse, or the amount of motion since the last
        /// mouse event was generated, depending on the value of the <see cref="dwFlags"/> 
        /// member. Absolute data is specified as the y coordinate of the mouse; relative data 
        /// is specified as the number of pixels moved.
        /// </summary>
        public Int32 dy { get; set; }

        /// <summary>
        /// <para>If <see cref="dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>,
        /// then <see cref="mouseData"/> specifies the amount of wheel movement. A positive value indicates 
        /// that the wheel was rotated forward, away from the user; a negative value indicates 
        /// that the wheel was rotated backward, toward the user. One wheel click is defined 
        /// as, which is 120.</para>
        /// 
        /// <para>Windows Vista: If <see cref="dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>, then dwData specifies 
        /// the amount of wheel movement. A positive value indicates that the wheel was 
        /// rotated to the right; a negative value indicates that the wheel was rotated 
        /// to the left. One wheel click is defined as WHEEL_DELTA, which is 120.</para>
        /// 
        /// <para>If <see cref="dwFlags"/> does not contain <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>, <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/>, or 
        /// <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/>, then <see cref="mouseData"/> should be zero.</para>
        /// 
        /// <para>If <see cref="dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/> or <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/>, then <see cref="mouseData"/> specifies 
        /// which X buttons were pressed or released. This value may be any combination of the 
        /// following flags.</para>
        /// </summary>
        public MouseData mouseData { get; set; }

        /// <summary>
        /// <para>A set of bit flags that specify various aspects of mouse motion and button clicks. 
        /// The bits in this member can be any reasonable combination of the following values.</para>
        /// 
        /// <para>The bit flags that specify mouse button status are set to indicate changes in status,
        /// not ongoing conditions.For example, if the left mouse button is pressed and held down, 
        /// <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTDOWN"/> is set when the left button is first pressed, but not for 
        /// subsequent motions.Similarly, <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTUP"/> is set only when the button is first
        /// released.</para>
        /// 
        /// <para>You cannot specify both the <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/> flag and either <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/> or 
        /// <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/> flags simultaneously in the <see cref="dwFlags"/> parameter, because they both 
        /// require use of the <see cref="mouseData"/> field.</para>
        /// </summary>
        public MouseInputDwFlag dwFlags { get; set; }

        /// <summary>
        /// The time stamp for the event, in milliseconds. If this parameter is 0, the system 
        /// will provide its own time stamp.
        /// </summary>
        public UInt32 time { get; set; }

        /// <summary>
        /// An additional value associated with the mouse event. An application calls 
        /// <see cref="User32.GetMessageExtraInfo"/> to obtain this extra information.
        /// </summary>
        public IntPtr dwExtraInfo { get; set; }
    }
}
