using WindowsVirtualInput.Native;

namespace WindowsVirtualInput
{
    public interface IInputDeviceStateAdaptor
    {
        bool IsHardwareKeyDown(VirtualKeyCode keyCode);

        bool IsHardwareKeyUp(VirtualKeyCode keyCode);
        bool IsKeyDown(VirtualKeyCode keyCode);

        bool IsKeyUp(VirtualKeyCode keyCode);

        bool IsTogglingKeyInEffect(VirtualKeyCode keyCode);
    }
}