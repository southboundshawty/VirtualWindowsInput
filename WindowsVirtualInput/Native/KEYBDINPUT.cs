using System;

namespace WindowsVirtualInput.Native
{
    internal struct KEYBDINPUT
    {
        public ushort KeyCode;

        public ushort Scan;

        public uint Flags;

        public uint Time;

        public IntPtr ExtraInfo;
    }
}