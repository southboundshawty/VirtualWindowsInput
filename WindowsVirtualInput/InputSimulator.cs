﻿namespace WindowsVirtualInput
{
    public class InputSimulator : IInputSimulator
    {
        public InputSimulator(IKeyboardSimulator keyboardSimulator, IMouseSimulator mouseSimulator,
            IInputDeviceStateAdaptor inputDeviceStateAdaptor)
        {
            Keyboard = keyboardSimulator;
            Mouse = mouseSimulator;
            InputDeviceState = inputDeviceStateAdaptor;
        }

        public InputSimulator()
        {
            Keyboard = new KeyboardSimulator(this);
            Mouse = new MouseSimulator(this);
            InputDeviceState = new WindowsVirtualInputDeviceStateAdaptor();
        }

        public IKeyboardSimulator Keyboard { get; }

        public IMouseSimulator Mouse { get; }

        public IInputDeviceStateAdaptor InputDeviceState { get; }
    }
}