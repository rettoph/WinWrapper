using System;
using System.Runtime.InteropServices;
using WinWrapper.User32.Enums;
using WinWrapper.User32.Factories;
using WinWrapper.User32.Structs;

namespace WinWrapper.User32
{
    public static class User32
    {
        [DllImport("User32.Dll")]
        public static extern UInt32 SendInput(UInt32 cInputs, Input[] pInputs, int cbSize);

        [DllImport("User32.Dll")]
        public static extern IntPtr GetMessageExtraInfo();

        #region Helper Methods
        public static UInt32 SendInput(Input pInput)
            => User32.SendInput(
                1,
                new Input[] { pInput },
                Marshal.SizeOf(typeof(Input)));

        /// <summary>
        /// Returns information about a simulated mouse event.
        /// </summary>
        /// <param name="dx">The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the <paramref name="dwFlags"/> member. Absolute data is specified as the x coordinate of the mouse; relative data is specified as the number of pixels moved.</param>
        /// <param name="dy">The absolute position of the mouse, or the amount of motion since the last mouse event was generated, depending on the value of the <paramref name="dwFlags"/> member. Absolute data is specified as the y coordinate of the mouse; relative data is specified as the number of pixels moved.</param>
        /// <param name="dwFlags">
        /// <para>A set of bit flags that specify various aspects of mouse motion and button clicks. The bits in this member can be any reasonable combination of the following values.</para>
        /// 
        /// <para>The bit flags that specify mouse button status are set to indicate changes in status, not ongoing conditions. For example, if the left mouse button is pressed and held down, <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTDOWN"/> is set when the left button is first pressed, but not for subsequent motions. Similarly, <see cref="MouseInputDwFlag.MOUSEEVENTF_LEFTUP"/> is set only when the button is first released.</para>
        /// 
        /// <para>You cannot specify both the <see cref="MouseInputDwFlag.MOUSEEVENTF_WHEEL"/> flag and either <see cref="MouseInputDwFlag.MOUSEEVENTF_XDOWN"/> or <see cref="MouseInputDwFlag.MOUSEEVENTF_XUP"/> flags simultaneously in the <see cref="MouseInput.dwFlags"/> parameter, because they both require use of the <see cref="MouseInput.mouseData"/> field.</para>
        /// </param>
        /// <param name="mouseData">
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
        /// </param>
        /// <param name="time">The time stamp for the event, in milliseconds. If this parameter is 0, the system will provide its own time stamp.</param>
        /// <param name="dwExtraInfo">An additional value associated with the mouse event. An application calls <see cref="User32.GetMessageExtraInfo"/> to obtain this extra information.</param>
        /// <returns></returns>
        public static UInt32 SendMouseInput(Int32 dx, Int32 dy, MouseInputDwFlag dwFlags, MouseData mouseData = 0, UInt32 time = 0, IntPtr dwExtraInfo = default(IntPtr))
            => User32.SendInput(
                pInput: InputFactory.CreateMouseInput(
                    dx: dx,
                    dy: dy,
                    dwFlags: dwFlags,
                    mouseData: mouseData,
                    time: time,
                    dwExtraInfo: dwExtraInfo));

        /// <summary>
        /// Returns information about a simulated keyboard event.
        /// </summary>
        /// <param name="wvk">A virtual-key code. The code must be a value in the range 1 to 254. If the <paramref name="dwFlags"/> member specifies <see cref="KeyBoardInputDwFlag.KEYEVENTF_UNICODE"/>, <paramref name="wvk"/> must be 0.</param>
        /// <param name="dwFlags">A hardware scan code for the key. If <paramref name="dwFlags"/> specifies <see cref="KeyBoardInputDwFlag.KEYEVENTF_UNICODE"/>, <paramref name="wScan"/> specifies a Unicode character which is to be sent to the foreground application.</param>
        /// <param name="wScan">Specifies various aspects of a keystroke.</param>
        /// <param name="time">The time stamp for the event, in milliseconds. If this parameter is zero, the system will provide its own time stamp.</param>
        /// <param name="dwExtraInfo">An additional value associated with the keystroke. Use the <see cref="User32.GetMessageExtraInfo"/> function to obtain this information.</param>
        /// <returns></returns>
        public static UInt32 SendKeyboardInput(KeyCode wvk, KeyBoardInputDwFlag dwFlags, UInt16 wScan = 0, UInt32 time = 0, IntPtr dwExtraInfo = default(IntPtr))
            => User32.SendInput(
                pInput: InputFactory.CreateKeyboardInput(
                    wvk: wvk,
                    dwFlags: dwFlags,
                    wScan: wScan,
                    time: time,
                    dwExtraInfo: dwExtraInfo));
        #endregion
    }
}
