using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WinWrapper.User32.Structs
{
    [StructLayout(LayoutKind.Explicit)]
    public struct InputUnion
    {
        [FieldOffset(0)]
        public MouseInput mi;

        [FieldOffset(0)]
        public KeyBoardInput ki;
    }
}
