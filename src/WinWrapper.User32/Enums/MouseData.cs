using System;
using System.Collections.Generic;
using System.Text;
using WinWrapper.User32.Structs;

namespace WinWrapper.User32.Enums
{
    /// <summary>
    /// <para>If <see cref="MouseInput.dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>, then <see cref="MouseInput.mouseData"/> specifies the amount of wheel movement. 
    /// A positive value indicates that the wheel was rotated forward, away from the user; a negative 
    /// value indicates that the wheel was rotated backward, toward the user. One wheel click is defined 
    /// as WHEEL_DELTA, which is 120.</para>
    /// 
    /// <para>Windows Vista: If <see cref="MouseInput.dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_HWHEEL"/>, then dwData specifies the amount of wheel 
    /// movement. A positive value indicates that the wheel was rotated to the right; a negative value 
    /// indicates that the wheel was rotated to the left. One wheel click is defined as WHEEL_DELTA, which is 120.</para>
    /// 
    /// <para>If <see cref="MouseInput.dwFlags"/> does not contain <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/>, <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/>, or <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/>, then 
    /// <see cref="MouseInput.mouseData"/> should be zero.</para>
    /// 
    /// <para>If <see cref="MouseInput.dwFlags"/> contains <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/> or <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/>, then <see cref="MouseInput.mouseData"/> specifies which X 
    /// buttons were pressed or released. This value may be any combination of the following flags.</para>
    /// 
    /// <para>
    /// <a href="https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput">
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-mouseinput
    /// </a>
    /// </para>
    /// </summary>
    public enum MouseData : UInt32
    {
        /// <summary>
        /// Set if the first X button is pressed or released.
        /// </summary>
        XBUTTON1 = 0x0001,

        /// <summary>
        /// Set if the second X button is pressed or released.
        /// </summary>
        XBUTTON2 = 0x0002
    }
}
