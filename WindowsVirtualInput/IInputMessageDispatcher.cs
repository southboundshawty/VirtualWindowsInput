using WindowsVirtualInput.Native;

namespace WindowsVirtualInput
{
    internal interface IInputMessageDispatcher
    {
        void DispatchInput(INPUT[] inputs);
    }
}